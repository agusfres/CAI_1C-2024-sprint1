using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Proveedor
    {
        Guid idUsuario;
        string nombre;
        string apellido;
        string email;
        string cuit;
        DateTime fechaAlta;
        DateTime? fechaBaja;

        public Proveedor(Guid idUsuario, string nombre, string apellido, string email, string cuit, DateTime fechaAlta, DateTime? fechaBaja)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.cuit = cuit;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
         
        }


        public Guid IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Cuit { get => cuit; set => cuit = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime? FechaBaja { get => fechaBaja; set => fechaBaja = value; }

    }
}
