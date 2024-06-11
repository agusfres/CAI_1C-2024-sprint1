using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Cliente : Persona
    {
        string direccion;
        string telefono;
        DateTime fechaAlta;
        DateTime fechaNacimiento;
        DateTime? fechaBaja;
        Guid idUsuario;
        string host;
        int dni;
        string estado;


        public Cliente(Guid id, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, Guid idUsuario, string host, int dni, string estado) : base(id, nombre, apellido, email)
        {
            this.direccion = direccion;
            this.telefono = telefono;
            this.fechaAlta = fechaAlta;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaBaja = fechaBaja;
            this.idUsuario = idUsuario;
            this.dni = dni;
            this.host = host;
            this.estado = estado;
        }


        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime? FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public Guid IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Host { get => host; set => host = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
