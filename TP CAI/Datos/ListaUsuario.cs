using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ListaUsuario
    {
        private List<Usuario> listaUsuarios;


        public Usuario BuscarUsuario(Guid id)
        {
            if (listaUsuarios != null)
            {
                foreach (Usuario usuario in listaUsuarios)
                {
                    if (usuario.IdUsuario == id)
                    {
                        return usuario;
                    }
                }
            }
            return null;
        }


        public Usuario BuscarUsuario(string nombreUsuario)
        {
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


        public void AgregarUsuario(Usuario usuario)
        {
            listaUsuarios.Add(usuario);
        }


        public void BajaUsuario(Guid id)
        {
            Usuario usuario = BuscarUsuario(id);
            if (usuario != null)
            {
                usuario.FechaBaja = DateTime.Now;
                usuario.Estado = "INACTIVO";
            }
        }


        public void ModificarContraseña(string nombreUsuario, string contraseña)
        {
            Usuario usuario = BuscarUsuario(nombreUsuario);
            usuario.Contraseña = contraseña;
            usuario.FechaUltimaAct = DateTime.Now;
        }


        public void ModificarEstado(string nombreUsuario, string estado)
        {
            Usuario usuario = BuscarUsuario(nombreUsuario);
            usuario.Estado = estado;
        }


        public void ModificarEstado(Guid id, string estado)
        {
            Usuario usuario = BuscarUsuario(id);
            usuario.Estado = estado;
        }
    }
}
