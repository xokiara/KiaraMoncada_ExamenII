using System;

namespace Entidades
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string CodigoUsuario { get; set; }
        public string IdentidadCliente { get; set; }
        public decimal Precio { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Descuento { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }

        public Ticket()
        {
        }

        public Ticket(int id, DateTime fecha, string codigoUsuario, string identidadCliente, decimal precio, decimal impuesto, decimal descuento, decimal subTotal, decimal total)
        {
            Id = id;
            Fecha = fecha;
            CodigoUsuario = codigoUsuario;
            IdentidadCliente = identidadCliente;
            Precio = precio;
            Impuesto = impuesto;
            Descuento = descuento;
            SubTotal = subTotal;
            Total = total;
        }
    }
}
