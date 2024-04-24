using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class AltaProveedor
    {
        Guid idUsuario;
        string nombre;
        string apellido;
        string email;
        string cuit;


        public AltaProveedor(Guid idUsuario, string nombre, string apellido, string email, string cuit)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.cuit = cuit;
        }


        public Guid IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Cuit { get => cuit; set => cuit = value; }

    }
}
