﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ListaUsuario
    {
        private List<Usuario> listaUsuariosLocal = new List<Usuario>();


        public Usuario BuscarUsuario(Guid id)
        {
            foreach (Usuario usuario in listaUsuariosLocal)
            {
                if (usuario.IdUsuario == id)
                {
                    return usuario;
                }
            }
            return null;
        }


        public Usuario BuscarUsuario(string nombreUsuario)
        {
            foreach (Usuario usuario in listaUsuariosLocal)
            {
                if (usuario.NombreUsuario == nombreUsuario)
                {
                    return usuario;
                }
            }
            return null;
        }


        public void AgregarUsuario(Usuario usuario)
        {
            listaUsuariosLocal.Add(usuario);
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
    }
}
