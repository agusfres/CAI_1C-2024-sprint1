using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
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


        public void AgregarUsuario(string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, int tipoUsuario, int dni, string contraseña)
        {
            // Ponemos host como 1 ya que al usar 5 el web service da error 409 porqu solo permite un enum de 1, 2 o 3
            int host = 1;
            AltaUsuario altaUsuario = new AltaUsuario(idAdministrador, host, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
            usuarioService.AgregarUsuario(altaUsuario);
            Usuario usuarioAuxiliar = BuscarUsuario(nombreUsuario);
            Usuario usuario = new Usuario(usuarioAuxiliar.Id, nombre, apellido, direccion, telefono, email, DateTime.Now, fechaNacimiento, null, null, nombreUsuario, tipoUsuario, dni, contraseña, host);
            GuardarUsuarios(usuario);
        }


        public Usuario BuscarUsuario(string nombreUsuario)
        {
            List<Usuario> listaUsuarios = TraerUsuariosActivos();

            if (listaUsuarios != null)
            {
                foreach (Usuario usuario in listaUsuarios)
                {
                    if (usuario.NombreUsuario == nombreUsuario)
                    {
                        return usuario;
                    }
                }
            }
            return null;
        }


        public List<Usuario> TraerUsuariosActivos()
        {
            return usuarioService.TraerUsuariosActivos(idAdministrador);
        }


        public void BorrarUsuario(Guid idUsuario)
        {
            BajaUsuario bajaUsuario = new BajaUsuario(idUsuario, idAdministrador);
            usuarioService.BorrarUsuario(bajaUsuario);
        }


        public void CambiarContraseña(string nombreUsuarioActual, string contraseñaActual, string contraseñaNueva)
        {
            UsuarioService.CambiarContraseña(nombreUsuarioActual, contraseñaActual, contraseñaNueva);
        }

        private void GuardarUsuarios(Usuario usuario)
        {

            string docPath = @"\TP CAI\UsuariosLocales.txt";
            StreamWriter writer = new StreamWriter(docPath);

            writer.WriteLine(usuario.Id + ";" + usuario.Nombre + ";" + usuario.Apellido + ";" + usuario.Direccion + ";" + usuario.Telefono + ";" + usuario.Email + ";" + usuario.FechaAlta + ";" + usuario.FechaNacimiento + ";"  + usuario.FechaBaja + ";" + usuario.FechaUltimaAct + ";" + usuario.NombreUsuario + ";" + usuario.TipoUsuario + ";" + usuario.Dni + ";" + usuario.Contraseña + ";" + usuario.Host);


        }
    }
}