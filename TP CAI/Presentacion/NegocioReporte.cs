using Persistencia;
using Datos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace Presentacion
{
    public class NegocioReporte
    {
        NegocioProducto negocioProducto = new NegocioProducto();
        NegocioUsuario negocioUsuario = new NegocioUsuario();
        string docPathAdaptado = @"C:\Users\USUARIOSISTEMA\VentasLocales.txt".Replace("USUARIOSISTEMA", Environment.UserName);


        public List<string> ReporteMasVendidoPorCategoria()
        {
            List<string> listaProductosMasVendidos = new List<string>();

            for (int categoria = 1; categoria <= 5; categoria++)
            {
                Dictionary<Guid, int> cantVendidaPorProd = new Dictionary<Guid, int>();
                StreamReader sr = new StreamReader(docPathAdaptado);
                string linea;

                while ((linea = sr.ReadLine()) != null)
                {
                    string[] vector = linea.Split('+');

                    int categoriaTxt = int.Parse(vector[6]);
                    Guid idProducto = Guid.Parse(vector[4]);
                    int cantidad = int.Parse(vector[7]);

                    try
                    {
                        if (categoria == categoriaTxt)
                        {
                            if (cantVendidaPorProd.ContainsKey(idProducto))
                            {
                                cantVendidaPorProd[idProducto] += cantidad;
                            }
                            else
                            {
                                cantVendidaPorProd.Add(idProducto, cantidad);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error");
                    }
                }

                sr.Close();

                if (cantVendidaPorProd.Count > 0)
                {
                    var diccionarioOrdenado = cantVendidaPorProd.OrderByDescending(x => x.Value);
                    Guid idProductoMasVendido = diccionarioOrdenado.First().Key;
                    Producto producto = negocioProducto.BuscarProducto(idProductoMasVendido);
                    listaProductosMasVendidos.Add(producto.Nombre);
                }
                else
                {
                    listaProductosMasVendidos.Add("No hay ventas de esta categoría");
                }
            }

            return listaProductosMasVendidos;
        }


        public List<ReporteVentasPorVendedor> ReporteVentasPorVendedor(int mes)
        {
            List<ReporteVentasPorVendedor> reporteVentas = new List<ReporteVentasPorVendedor>();

            StreamReader sr = new StreamReader(docPathAdaptado);
            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                string[] vector = linea.Split('+');

                Guid idVendedor = Guid.Parse(vector[3]);
                int cantidad = int.Parse(vector[7]);
                double total = double.Parse(vector[9]);
                DateTime fechaVenta = DateTime.Parse(vector[10]);
                
                try
                {
                    if (fechaVenta.Month == mes)
                    {
                        Usuario usuario = negocioUsuario.BuscarUsuario(idVendedor);

                        ReporteVentasPorVendedor vendedorExistente = reporteVentas.FirstOrDefault(x => x.Nombre == usuario.Nombre);
                        if (vendedorExistente != null)
                        {
                            vendedorExistente.CantidadVentas += cantidad;
                            vendedorExistente.MontoTotal += total;
                        }
                        else
                        {
                            ReporteVentasPorVendedor reporteIndividual = new ReporteVentasPorVendedor(usuario.Nombre, cantidad, total);
                            reporteVentas.Add(reporteIndividual);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error");
                }
            }

            sr.Close();

            return reporteVentas;
        }
    }
}
