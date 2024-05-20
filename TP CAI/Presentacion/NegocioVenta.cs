using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class NegocioVenta
    {
        private Guid idUsuario = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        //public List<Producto> AgregarAlCarrito(string nombre, int cantidad)
        //{
            // Ponemos host como 1 ya que al usar 5 el web service da error 409 porqu solo permite un enum de 1, 2 o 3
            // int host = 1;
            //AltaUsuario altaUsuario = new AltaUsuario(idAdministrador, host, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
            //usuarioService.AgregarUsuario(altaUsuario);
            //Usuario usuarioAuxiliar = BuscarUsuario(nombreUsuario);
            //Usuario usuario = new Usuario(usuarioAuxiliar.Id, nombre, apellido, direccion, telefono, email, DateTime.Now, fechaNacimiento, null, null, nombreUsuario, tipoUsuario, dni, contraseña, host, "INACTIVO");
            //AgregarUsuarioBaseLocal(usuario);
        }
    }
//}
