using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CAI
{
    public class Usuario
    {
        int id;
        string nombre;
        string apellido;
        string direccion;
        string telefono;
        string email;
        DateTime fechaAlta;
        DateTime fechaNac;
        DateTime? fechaBaja;
        DateTime? fechaUltimaAct;
        string nombreUsuario;
        int tipoUsuario;
        int DNI;
        string contraseña;


        public Usuario(int id, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaAlta, DateTime fechaNac, DateTime? fechaBaja, DateTime? fechaUltimaAct, string nombreUsuario, int tipoUsuario, int DNI, string contraseña)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fechaAlta = fechaAlta;
            this.fechaNac = fechaNac;
            this.fechaBaja = fechaBaja;
            this.fechaUltimaAct = fechaUltimaAct;
            this.nombreUsuario = nombreUsuario;
            this.tipoUsuario = tipoUsuario;
            this.DNI = DNI;
            this.contraseña = contraseña;
        }


        public int GetId()
        {
            return this.id;
        }
    }
}
