using System;

namespace Entidades
{
    public class Usuario
    {
        public string CodigoUsuario { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigoUsuario, string nombre, string contraseña, string correo, DateTime fechaCreacion)
        {
            CodigoUsuario = codigoUsuario;
            Nombre = nombre;
            Contraseña = contraseña;
            Correo = correo;
            FechaCreacion = fechaCreacion;
        }
    }
}
