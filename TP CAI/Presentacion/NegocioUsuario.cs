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
        private Guid idAdministrador = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        private ListaUsuario listaUsuarios = new ListaUsuario();


        public void AgregarUsuario(string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, int tipoUsuario, int dni, string contraseña)
        {
            // Ponemos host como 1 ya que al usar 5 la api da error 409
            int host = 1;

            AltaUsuario altaUsuario = new AltaUsuario(idAdministrador, host, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
            usuarioService.AgregarUsuario(altaUsuario);

            // Temporariamente guardamos una lista de usuarios localmente, solamente para guardar sus datos de fechaAlta, fechaBaja, fechaUltimaAct y tipoUsuario que no se postean en la api
            Usuario usuario = new Usuario(idAdministrador, nombre, apellido, direccion, telefono, email, DateTime.Now, fechaNacimiento, null, null, nombreUsuario, tipoUsuario, dni, contraseña, host, "INACTIVO");

            listaUsuarios.AgregarUsuario(usuario);
        }


        public string BuscarDni(int dni, List<Usuario> listaUsuarios)
        {
            Usuario usuario = listaUsuarios.Find(a => a.Dni == dni);
            if (usuario == null)
            {
                return "ERROR";
            }
            else
            {
                return usuario.Nombre + Environment.NewLine + usuario.Apellido;
            }
        }


        public void ModificarUsuario(Guid idUsuario, string direccion, string telefono, string email)
        {
            usuarioService.ModificarUsuario(idUsuario, direccion, telefono, email);
        }


        public List<Usuario> ListarUsuariosApi()
        {
            return usuarioService.TraerUsuariosActivos(idAdministrador);
        }


        public void BorrarUsuario(Guid idUsuario)
        {
            BajaUsuario bajaUsuario = new BajaUsuario(idUsuario, idAdministrador);
            usuarioService.BorrarUsuario(bajaUsuario);
        }
    }
}