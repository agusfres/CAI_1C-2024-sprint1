using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class NegocioUsuario
    {
        public void Alta(int id, string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, DateTime? fechaUltimaAct, string nombreUsuario, int tipoUsuario, int dni, string contraseña, string host, List <Usuario> usuarios)
        {

            Usuario usuario = new Usuario( id, nombre, apellido, direccion, telefono, email,  fechaAlta, fechaNacimiento, fechaBaja, fechaUltimaAct, nombreUsuario, tipoUsuario, dni, contraseña, host);
            usuarios.Add(usuario);
        }
        public string BuscarDni(int dni, List<Usuario> usuarios)
        {


            Usuario usuario = usuarios.Find(a => a.dni = dni);
            if (usuario == null)
            {
                return  "ERROR";
            }
            else
            {
                return  usuario.nombre + Environment.NewLine + usuario.apellido;
            }
        }
        public void Delete(int dni, List<Usuario> usuarios)
        {
            Usuario usuario = usuarios.Find(a => a.dni = dni);
            usuario.fechaBaja = DateTime.Now;
        }
    }
}

