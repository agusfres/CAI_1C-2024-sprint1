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
        public void DevolucionCompra(string idVentaIngresado)
        {
            string tempPath = Path.GetTempFileName(); // Ruta temporal para escribir el contenido actualizado

            StreamReader sr = new StreamReader(docPathAdaptado);
            StreamWriter sw = new StreamWriter(tempPath);
            string linea;
            while ((linea = sr.ReadLine()) != null)
            {
                string[] vector = linea.Split('+');
                // Si la línea actual no coincide con la línea que deseas eliminar, escríbela en el archivo temporal
                if (vector[1] != idVentaIngresado)
                {
                    sw.WriteLine(linea);
                }

                else
                {
                    try
                    {
                        string idCarrito = vector[0];
                        string idVenta = vector[1];
                        string idCliente = vector[2];
                        string idUsuario = vector[3];
                        string idProducto = vector[4];
                        string nombre = vector[5];
                        string idCategoria = vector[6];
                        string cantidad = vector[7];
                        string precio = vector[8];
                        string total = vector[9];
                        string fechaAlta = vector[10];


                        sw.WriteLine(idCarrito + "+" + idVenta + "+" + idCliente + "+" + idUsuario + "+" + idProducto + "+" + nombre + "+" + idCategoria + "+" + cantidad + "+" + precio + "+" + total + "+" + fechaAlta + "+0");
                    }
                    catch { Console.WriteLine("Error"); }
                }
            }
            sw.Close();
            sr.Close();
            // Reemplaza el archivo original con el archivo temporal
            System.IO.File.Delete(docPathAdaptado);
            System.IO.File.Move(tempPath, docPathAdaptado);
            // Borra el archivo temporal
            System.IO.File.Delete(tempPath);
        }

        public string BuscarVentaBaseLocal(string idVenta)
        {
            StreamReader sr = new StreamReader(docPathAdaptado);
            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                string[] vector = linea.Split('+');
                // Si la línea actual no coincide con la línea que deseas eliminar, escríbela en el archivo temporal
                if (vector[1] == idVenta)
                {
                    return "";
                }
            }
            sr.Close();
            return "No existe la Venta";
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

