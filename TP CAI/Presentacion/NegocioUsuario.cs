using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;

namespace Negocio
{
    public class NegocioUsuario
    {
        private UsuarioService usuarioService = new UsuarioService();
        private List<Usuario> listaUsuarios = new List<Usuario>();
        private Guid idAdministrador = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");

        public void AgregarUsuario(string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, DateTime? fechaUltimaAct, string nombreUsuario, int tipoUsuario, int dni, string contraseña, int host)
        {            
            AltaUsuario altaUsuario = new AltaUsuario(idAdministrador, host, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
            usuarioService.AgregarUsuario(altaUsuario);

            // Temporariamente guardamos una lista de usuarios localmente, solamente para guardar sus datos de fechaAlta, fechaBaja, fechaUltimaAct y tipoUsuario que no se postean en la api
            Usuario usuario = new Usuario(idAdministrador, nombre, apellido, direccion, telefono, email, fechaAlta, fechaNacimiento, fechaBaja, fechaUltimaAct, nombreUsuario, tipoUsuario, dni, contraseña, host);
            
            listaUsuarios.Add(usuario);
        }

        public string BuscarDni(int dni, List<Usuario> listaUsuarios)
        {
            Usuario usuario = listaUsuarios.Find(a => a.Dni == dni);
            if (usuario == null)
            {
                return  "ERROR";
            }
            else
            {
                return  usuario.Nombre + Environment.NewLine + usuario.Apellido;
            }
        }


        public void ModificarUsuario(Guid idUsuario, string direccion, string telefono, string email)
        {
            usuarioService.ModificarUsuario(idUsuario, direccion, telefono, email);

        }


        public List<Usuario> ListarUsuarios()
        {
            return usuarioService.TraerUsuariosActivos(idAdministrador);
        }


        public void BorrarUsuario(Guid idUsuario)
        {
            BajaUsuario bajaUsuario = new BajaUsuario(idUsuario, idAdministrador);
            usuarioService.BorrarUsuario(bajaUsuario);
            if (listaUsuarios.Count > 0)
            {
                Usuario usuario = listaUsuarios.Find(a => a.IdUsuario == idUsuario);
                if (usuario != null)
                {
                    usuario.FechaBaja = DateTime.Now;
                }
            }
        }
    }
}

