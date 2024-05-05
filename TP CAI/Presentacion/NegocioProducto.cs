using Datos;
using Persistencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    internal class NegocioProducto
    {
        private ProductoService productoService = new ProductoService();
        private Guid idAdministrador = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        string rutaLocal = @"C:\Users\USUARIOSISTEMA\OneDrive\Documentos\GitHub\CAI_1C-2024-sprint1\TP CAI\Productos.txt";
        public void AgregarProducto(Guid id,Guid idCategoria, Guid idUsuario, Guid idProveedor, double precio, int stock)
        {
           // AltaProducto altaProducto = new AltaProducto(idCategoria, idUsuario, idProveedor, precio, stock);
           // productoService.AgregarProducto(altaProducto);
           // Producto producto = new Producto(id,idCategoria,DateTime.Now,null, precio, stock, idProveedor, idUsuario);
           // AgregarProductoBaseLocal(producto);

        }
        private void AgregarProductoBaseLocal(Producto producto)
        {
            string docPath = rutaLocal;
            string nombreUsuarioSistema = Environment.UserName;
            string docPathAdaptado = docPath.Replace("USUARIOSISTEMA", nombreUsuarioSistema);

            StreamWriter writer = new StreamWriter(docPathAdaptado, true);

            try
            {
                writer.WriteLine(producto.Id + "+" + producto.IdCategoria + "+" + producto.Nombre +  "+" + producto.FechaAlta + "+null+" + producto.Precio + "+" + producto.Stock + "+" + producto.IdUsuario + "+" + producto.IdProveedor);
            }
            catch
            {
                Console.WriteLine("error");
            }
            writer.Close();
        }
    }
}
