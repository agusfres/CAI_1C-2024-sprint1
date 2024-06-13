using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class Usuario : Persona
    {
        string direccion;
        string telefono;
        DateTime fechaAlta;
        DateTime fechaNacimiento;
        DateTime? fechaBaja;
        DateTime? fechaUltimaAct;
        string nombreUsuario;
        int dni;
        string contraseña;
        int host;
        string estado;


        public Usuario(Guid id, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, DateTime? fechaUltimaAct, string nombreUsuario, int dni, string contraseña, int host,string estado) : base(id, nombre, apellido, email)
            {
            this.direccion = direccion;
            this.telefono = telefono;
            this.fechaAlta = fechaAlta;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaBaja = fechaBaja;
            this.fechaUltimaAct = fechaUltimaAct;
            this.nombreUsuario = nombreUsuario;
            this.dni = dni;
            this.contraseña = contraseña;
            this.host = host;
            this.estado = estado;
        }


        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime? FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public DateTime? FechaUltimaAct { get => fechaUltimaAct; set => fechaUltimaAct = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Host { get => host; set => host = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
