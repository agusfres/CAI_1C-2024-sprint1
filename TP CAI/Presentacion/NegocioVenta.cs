using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Presentacion
{
    public class NegocioVenta
    {
        private VentaService ventaService = new VentaService();
        string docPathAdaptado = @"C:\Users\USUARIOSISTEMA\VentasLocales.txt".Replace("USUARIOSISTEMA", Environment.UserName);


        public void AgregarVenta(string dni, Guid idUsuario, List<CarritoProducto> carritoProductos)
        {
            NegocioCliente negocioCliente = new NegocioCliente();
            Cliente cliente = negocioCliente.BuscarCliente(Int32.Parse(dni));
            Guid idCarrito = GenerarGuidRandom();

            foreach (CarritoProducto itemCarrito in carritoProductos)
            {
                Guid idCliente = cliente.Id;
                Guid idProducto = itemCarrito.IdProducto;
                string nombre = itemCarrito.Nombre;
                int idCategoria = itemCarrito.IdCategoria;
                int cantidad = itemCarrito.Cantidad;
                double precio =  itemCarrito.Precio;
                double total = cantidad * precio;

                ventaService.AgregarVenta(new AltaVenta(idCliente, idUsuario, idProducto, cantidad));
                
                Guid idVenta = ventaService.GetUltimaVentaCargada(cliente.Id);

                AgregarVentaBaseLocal(idCarrito, idVenta, idCliente, idUsuario, idProducto, nombre, idCategoria, cantidad, precio, total);
            }
        }


        public void AgregarVentaBaseLocal(Guid idCarrito, Guid idVenta, Guid idCliente, Guid idUsuario, Guid idProducto, string nombre, int idCategoria, int cantidad, double precio, double total)
        {
            StreamWriter writer = new StreamWriter(docPathAdaptado, true);

            try
            {
                writer.WriteLine(idCarrito + "+" + idVenta + "+" + idCliente + "+" + idUsuario + "+" + idProducto + "+" + nombre + "+" + idCategoria + "+" + cantidad + "+" + precio + "+" + total + "+" + DateTime.Now + "+1");
            }
            catch
            {
                Console.WriteLine("error");
            }

            writer.Close();
        }


        public double DescuentoPrimerCompra(int dni, double importeResto, double importeElectro)
        {
            double descuento;
            NegocioCliente negocioCliente = new NegocioCliente();
            Cliente cliente = negocioCliente.BuscarCliente(dni);

            List<Venta> ventasCliente = ventaService.GetVentasByCliente(cliente.Id);

            if (ventasCliente.Count == 0)
            {
                descuento = (importeResto + importeElectro) * 0.05;
            }
            else
            {
                descuento = 0;
            }

            return descuento;
        }


        private Guid GenerarGuidRandom()
        {
            Random random = new Random();
            byte[] bytes = new byte[16];
            random.NextBytes(bytes);
            Guid randomGuid = new Guid(bytes);
            return randomGuid;
        }
    }
}

