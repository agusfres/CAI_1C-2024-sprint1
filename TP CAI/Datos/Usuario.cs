using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuario
    {
        Guid idUsuario;
        string nombre;
        string apellido;
        string direccion;
        string telefono;
        string email;
        DateTime fechaAlta;
        DateTime fechaNacimiento;
        DateTime? fechaBaja;
        DateTime? fechaUltimaAct;
        string nombreUsuario;
        int tipoUsuario;
        int dni;
        string contraseña;
        int host;

        public Usuario(Guid idUsuario, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, DateTime? fechaUltimaAct, string nombreUsuario, int tipoUsuario, int dni, string contraseña, int host)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaAlta = fechaAlta;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaBaja = fechaBaja;
            this.fechaUltimaAct = fechaUltimaAct;
            this.nombreUsuario = nombreUsuario;
            this.tipoUsuario = tipoUsuario;
            this.dni = dni;
            this.contraseña = contraseña;
            this.host = host;
        }

        public Guid IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime? FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public DateTime? FechaUltimaAct { get => fechaUltimaAct; set => fechaUltimaAct = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public int TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Host { get => host; set => host = value; }
    }
}
