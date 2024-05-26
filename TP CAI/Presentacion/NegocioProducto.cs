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
        private Guid idAdministrador = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        string rutaLocal = @"C:\Users\USUARIOSISTEMA\ProductosLocales.txt";


        public void AgregarProducto(string nombre, int idCategoria, double precio, int stock, Guid idProveedor)
        {
            AltaProducto altaProducto = new AltaProducto(idCategoria, idAdministrador, idProveedor, nombre, precio, stock);
            productoService.AgregarProducto(altaProducto);

            Producto productoAuxiliar = BuscarProducto(nombre);

            Producto producto = new Producto(productoAuxiliar.IdProducto, idCategoria, nombre, DateTime.Now, null, precio, stock, idAdministrador, idProveedor);
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


        private void AgregarProductoBaseLocal(Producto producto)
        {
            string docPath = rutaLocal;
            string nombreUsuarioSistema = Environment.UserName;
            string docPathAdaptado = docPath.Replace("USUARIOSISTEMA", nombreUsuarioSistema);

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
