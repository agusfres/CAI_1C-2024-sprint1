using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;

namespace Negocio
{
    public class NegocioUsuario
    {
        private UsuarioService usuarioService = new UsuarioService();
        private String idAdministrador = "70b37dc1-8fde-4840-be47-9ababd0ee7e5";

        public void Alta(string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaAlta, DateTime fechaNacimiento, DateTime? fechaBaja, DateTime? fechaUltimaAct, string nombreUsuario, int tipoUsuario, int dni, string contraseña, string host)
        {
            TransformarStringAGuid tab = new TransformarStringAGuid();
            Guid idAdministradorModificado = tab.TransformarStringGuid(idAdministrador);

            AltaUsuario altaUsuario = new AltaUsuario(idAdministradorModificado, nombre, apellido, direccion, telefono, email, fechaAlta, fechaNacimiento, fechaBaja, fechaUltimaAct, nombreUsuario, tipoUsuario, dni, contraseña, host);
            usuarioService.AgregarUsuario(altaUsuario);

        }

        public string BuscarDni(int dni, List<Usuario> usuarios)
        {

            Usuario usuario = usuarios.Find(a => a.Dni == dni);
            if (usuario == null)
            {
                return  "ERROR";
            }
            else
            {
                return  usuario.Nombre + Environment.NewLine + usuario.Apellido;
            }
        }
        public void Delete(int dni, List<Usuario> usuarios)
        {
            Usuario usuario = usuarios.Find(a => a.Dni == dni);
            usuario.FechaBaja = DateTime.Now;
        }

        

        public void modificarUsuario(Guid idUsuario, string direccion, string telefono, string email)
        {
            usuarioService.ModificarUsuario(idUsuario, direccion, telefono, email);

        }

        public List<Usuario> listarUsuarios()
        {
            return usuarioService.TraerUsuariosActivos();
        }

        public void borrarUsuario(Guid idUsuario)
        {
            usuarioService.BorrarUsuario(idUsuario);
        }
    }

    public class TransformarStringAGuid
    {
        public Guid TransformarStringGuid(string texto)
        {
            Guid salida;
            if (Guid.TryParse(texto, out salida))
            {
                return salida;
            }
            return Guid.Empty;
        }

    }
}

