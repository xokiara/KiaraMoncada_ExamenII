using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace Datos
{
    public class SoporteDB
    {
        string cadena = "server=localhost; user=root; database=soporte; password=valladaresk28";

        public bool Insertar(Soporte soporte)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO soporte VALUES ");
                sql.Append(" (@Codigo, @Descripcion, @Precio, @EstaActivo); ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = soporte.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = soporte.Descripcion;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = soporte.Precio;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = soporte.EstaActivo;
                        comando.ExecuteNonQuery();
                        inserto = true;
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return inserto;

        }

        public bool Editar(Soporte soporte)
        {
            bool edito = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE soporte SET ");
                sql.Append(" Descripcion =  @Descripcion, Precio = @Precio, EstaActivo = @EstaActivo ");
                sql.Append(" WHERE Codigo = @Codigo; ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = soporte.Codigo;
                        comando.Parameters.Add("@Descripcion", MySqlDbType.VarChar, 200).Value = soporte.Descripcion;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = soporte.Precio;
                        comando.Parameters.Add("@EstaActivo", MySqlDbType.Bit).Value = soporte.EstaActivo;
                        comando.ExecuteNonQuery();
                        edito = true;
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return edito;
        }

        public bool Eliminar(string codigo)
        {
            bool elimino = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM soporte ");
                sql.Append(" WHERE Codigo = @Codigo; ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = codigo;
                        comando.ExecuteNonQuery();//No devuelve ningún registro
                        elimino = true;
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return elimino;
        }

        public DataTable DevolverSoporte()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM soporte ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return dt;
        }

        public Soporte DevolverSoportePorCodigo(string codigo)
        {
            Soporte soporte = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM soporte WHERE Codigo = @Codigo; ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", MySqlDbType.VarChar, 80).Value = codigo;
                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            soporte = new Soporte();

                            soporte.Codigo = codigo;
                            soporte.Descripcion = dr["Descripcion"].ToString();
                            soporte.Precio = Convert.ToDecimal(dr["Precio"]);
                            soporte.EstaActivo = Convert.ToBoolean(dr["EstaActivo"]);

                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return soporte;
        }

        public DataTable DevolverSoportePorDescripcion(string descripcion)
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM soporte WHERE Descripcion LIKE '%" + descripcion + "%'");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        dt.Load(dr);
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return dt;
        }
    }
}
