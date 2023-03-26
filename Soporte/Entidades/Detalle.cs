namespace Entidades
{
    public class Detalle
    {
        public int Id { get; set; }
        public int IdTicket { get; set; }
        public string CodigoSoporte { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }

        public Detalle()
        {
        }

        public Detalle(int id, int idTicket, string codigoSoporte, string descripcion, decimal precio, decimal total)
        {
            Id = id;
            IdTicket = idTicket;
            CodigoSoporte = codigoSoporte;
            Descripcion = descripcion;
            Precio = precio;
            Total = total;
        }
    }


}
