﻿using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class NegocioVenta
    {
        private VentaService ventaService = new VentaService();
        private Guid idUsuario = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        string rutaLocal = @"C:\Users\USUARIOSISTEMA\VentasLocales.txt";


        public void AgregarVenta(string dni, Guid idUsuario, List<CarritoProducto> carritoProductos)
        {
            NegocioCliente negocioCliente = new NegocioCliente();
            Cliente cliente = negocioCliente.BuscarCliente(Int32.Parse(dni));

            foreach (CarritoProducto itemCarrito in carritoProductos)
            {
                ventaService.AgregarVenta(new AltaVenta(cliente.Id, idUsuario, itemCarrito.IdProducto, itemCarrito.Cantidad));
            }

            AgregarVentaBaseLocal(carritoProductos);
        }


        public void AgregarVentaBaseLocal(List<CarritoProducto> carritoProductos)
        {
            string docPath = rutaLocal;
            string nombreUsuarioSistema = Environment.UserName;
            string docPathAdaptado = docPath.Replace("USUARIOSISTEMA", nombreUsuarioSistema);

            StreamWriter writer = new StreamWriter(docPathAdaptado, true);

            try
            {
                Guid idVentaLocal = Guid.NewGuid();
                foreach (CarritoProducto c in carritoProductos)
                {
                    writer.WriteLine(c.IdProducto + "+" + c.Nombre + "+" + c.Cantidad + "+" + c.Precio + "+" + (c.Precio*c.Cantidad) + "+" + idVentaLocal);
                }
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
    }
}

