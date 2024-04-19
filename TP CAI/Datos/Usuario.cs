using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public DateTime fechaAlta { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public DateTime? fechaBaja { get; set; }
        public DateTime? fechaUltimaAct { get; set; }
        public string nombreUsuario { get; set; }
        public int tipoUsuario { get; set; }
        public int dni { get; set; }
        public string contraseña { get; set; }
        public string host { get; set; }



        public Usuario(int Id, string Nombre, string Apellido, string Direccion, string Telefono, string Email, DateTime FechaAlta, DateTime FechaNacimiento, DateTime? FechaBaja, DateTime? FechaUltimaAct, string NombreUsuario, int TipoUsuario, int Dni, string Contraseña, string Host)
        {
            id = Id;
            nombre = Nombre;
            apellido = Apellido;
            direccion = Direccion;
            telefono = Telefono;
            email = Email;
            fechaAlta = FechaAlta;
            fechaNacimiento = FechaNacimiento;
            fechaBaja = FechaBaja;
            fechaUltimaAct = FechaUltimaAct;
            nombreUsuario = NombreUsuario;
            tipoUsuario = TipoUsuario;
            dni = Dni;
            contraseña = Contraseña;
            host = Host;
        }


        public int GetId()
        {
            return this.id;
        }
    }
}
