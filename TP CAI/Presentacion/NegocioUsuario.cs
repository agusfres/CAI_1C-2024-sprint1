using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;
using static System.Net.WebRequestMethods;


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
            Usuario usuario = new Usuario(usuarioAuxiliar.Id, nombre, apellido, direccion, telefono, email, DateTime.Now, fechaNacimiento, null, null, nombreUsuario, tipoUsuario, dni, contraseña, host,"INACTIVO");
            AgregarUsuarioBaseLocal(usuario);
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
            ModificarEstadoBaseLocal(nombreUsuarioActual,contraseñaNueva);
        }


        private void AgregarUsuarioBaseLocal(Usuario usuario)
        {
            string docPath = @"C:\Users\Cata\OneDrive\Documentos\GitHub\CAI_1C-2024-sprint1\TP CAI\UsuariosLocales.txt";
            StreamWriter writer = new StreamWriter(docPath, true);

            try
            {
                writer.WriteLine(usuario.Id + "+" + usuario.Nombre + "+" + usuario.Apellido + "+" + usuario.Direccion + "+" + usuario.Telefono + "+" + usuario.Email + "+" + usuario.FechaAlta + "+" + usuario.FechaNacimiento + "+" + usuario.FechaBaja + "+" + usuario.FechaUltimaAct + "+" + usuario.NombreUsuario + "+" + usuario.TipoUsuario + "+" + usuario.Dni + "+" + usuario.Contraseña + "+" + usuario.Host + "+" + usuario.Estado);
            }
            catch
            {
                Console.WriteLine("error");
            }
            writer.Close();
        }
        private void ModificarEstadoBaseLocal(string usuario,string contraseña)
        {
            string docPath = @"C:\Users\Cata\OneDrive\Documentos\GitHub\CAI_1C-2024-sprint1\TP CAI\UsuariosLocales.txt";
            string tempPath = Path.GetTempFileName(); // Ruta temporal para escribir el contenido actualizado

            using (StreamReader sr = new StreamReader(docPath))
            using (StreamWriter sw = new StreamWriter(tempPath))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] vector = linea.Split('+');
                    // Si la línea actual no coincide con la línea que deseas eliminar, escríbela en el archivo temporal
                    if (vector[10] != usuario)
                    {
                        sw.WriteLine(linea);
                    }
                    else
                    {
                        try 
                        { 
                            sw.WriteLine(vector[0] + '+' + vector[1] + '+' + vector[2] + '+' + vector[3] + '+' + vector[4] + '+' + vector[5] + '+' + vector[6] + '+' + vector[7] + '+' + vector[8] + '+' + vector[9] + '+' + vector[10] + '+' + vector[11] + '+' + vector[12] + '+' +contraseña + '+' + vector[14] + "+ACTIVO") ;
                        }
                        catch { continue;  }
                    }
                }
            }

            // Reemplaza el archivo original con el archivo temporal
            System.IO.File.Delete(docPath);
            System.IO.File.Move(tempPath, docPath);

            // Borra el archivo temporal
            System.IO.File.Delete(tempPath);

        }
    }
}
