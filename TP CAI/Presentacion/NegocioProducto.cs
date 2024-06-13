using Datos;
using Persistencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class NegocioProducto
    {
        private ProductoService productoService = new ProductoService();
        string docPathAdaptado = @"C:\Users\USUARIOSISTEMA\ProductosLocales.txt".Replace("USUARIOSISTEMA", Environment.UserName);


        public void AgregarProducto(string nombre, int idCategoria, double precio, int stock, Guid idProveedor)
        {
            AltaProducto altaProducto = new AltaProducto(idCategoria, UsuarioLogueado.usuario.Id, idProveedor, nombre, precio, stock);
            productoService.AgregarProducto(altaProducto);

            Producto productoAuxiliar = BuscarProducto(nombre);

            Producto producto = new Producto(productoAuxiliar.IdProducto, idCategoria, nombre, DateTime.Now, null, precio, stock, UsuarioLogueado.usuario.Id, idProveedor);
            AgregarProductoBaseLocal(producto);
        }


        public List<Producto> TraerProductos()
        {
            return productoService.TraerProductos();
        }


        public Producto BuscarProductoCat(int categoria)
        {
            List<Producto> listaProductos = TraerProductos();

            if (listaProductos != null)
            {
                foreach (Producto producto in listaProductos)
                {
                    if (producto.IdCategoria == categoria)
                    {
                        return producto;
                    }
                }
            }

            return null;
        }


        public Producto BuscarProducto(string nombre)
        {
            List<Producto> listaProductos = TraerProductos();

            if (listaProductos != null)
            {
                foreach (Producto producto in listaProductos)
                {
                    if (producto.Nombre == nombre)
                    {
                        return producto;
                    }
                }
            }

            return null;
        }


        public Producto BuscarProducto(Guid idProducto)
        {
            List<Producto> listaProductos = TraerProductos();

            if (listaProductos != null)
            {
                foreach (Producto producto in listaProductos)
                {
                    if (producto.IdProducto == idProducto)
                    {
                        return producto;
                    }
                }
            }

            return null;
        }


        private void AgregarProductoBaseLocal(Producto producto)
        {
            StreamWriter writer = new StreamWriter(docPathAdaptado, true);

            try
            {
                writer.WriteLine(producto.IdProducto + "+" + producto.IdCategoria + "+" + producto.Nombre + "+" + producto.FechaAlta + "+null+" + producto.Precio + "+" + producto.Stock + "+" + producto.IdUsuario + "+" + producto.IdProveedor);
            }
            catch
            {
                Console.WriteLine("error");
            }

            writer.Close();
        }
    }
}
