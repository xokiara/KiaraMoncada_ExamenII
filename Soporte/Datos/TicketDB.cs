﻿using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos
{
    public class TicketDB
    {
        string cadena = "server=localhost; user=root; database=soporte; password=valladaresk28";

        public bool Guardar(Ticket ticket, List<Detalle> detalles)
        {
            bool inserto = false;
            int idTicket = 0;
            try
            {
                StringBuilder sqlTicket = new StringBuilder();
                sqlTicket.Append(" INSERT INTO ticket (Fecha, IdentidadCliente, CodigoUsuario, ISV, Descuento, SubTotal, Total) VALUES (@Fecha, @IdentidadCliente, @CodigoUsuario, @ISV, @Descuento, @SubTotal, @Total); ");
                sqlTicket.Append(" SELECT LAST_INSERT_ID(); ");

                StringBuilder sqlDetalle = new StringBuilder();
                sqlDetalle.Append(" INSERT INTO detalle (IdTicket, CodigoSoporte, Precio, Total) VALUES (@IdTicket, @CodigoSoporte, @Precio, @Total); ");

                using (MySqlConnection con = new MySqlConnection(cadena))
                {
                    con.Open();

                    MySqlTransaction transaction = con.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    try
                    {

                        using (MySqlCommand cmd1 = new MySqlCommand(sqlTicket.ToString(), con, transaction))
                        {
                            cmd1.CommandType = System.Data.CommandType.Text;
                            cmd1.Parameters.Add("@Fecha", MySqlDbType.DateTime).Value = ticket.Fecha;
                            cmd1.Parameters.Add("@IdentidadCliente", MySqlDbType.VarChar, 25).Value = ticket.IdentidadCliente;
                            cmd1.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = ticket.CodigoUsuario;
                            cmd1.Parameters.Add("@ISV", MySqlDbType.Decimal).Value = ticket.ISV;
                            cmd1.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = ticket.Descuento;
                            cmd1.Parameters.Add("@SubTotal", MySqlDbType.Decimal).Value = ticket.SubTotal;
                            cmd1.Parameters.Add("@Total", MySqlDbType.Decimal).Value = ticket.Total;
                            idTicket = Convert.ToInt32(cmd1.ExecuteScalar());
                        }

                        foreach (Detalle detalle in detalles)
                        {
                            using (MySqlCommand cmd2 = new MySqlCommand(sqlDetalle.ToString(), con, transaction))
                            {
                                cmd2.CommandType = System.Data.CommandType.Text;
                                cmd2.Parameters.Add("@IdTicket", MySqlDbType.Int32).Value = idTicket;
                                cmd2.Parameters.Add("@CodigoSoporte", MySqlDbType.VarChar, 50).Value = detalle.CodigoSoporte;
                                cmd2.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = detalle.Precio;
                                cmd2.Parameters.Add("@Total", MySqlDbType.Decimal).Value = detalle.Total;
                                cmd2.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        inserto = true;

                    }
                    catch (System.Exception)
                    {
                        inserto = false;
                        transaction.Rollback();

                    }
                }
            }
            catch (System.Exception)
            {

            }
            return inserto;

        }

    }
}
