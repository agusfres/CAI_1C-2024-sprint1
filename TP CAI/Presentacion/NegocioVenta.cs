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
        private Guid idUsuario = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        string rutaLocal = @"C:\Users\USUARIOSISTEMA\VentasLocales.txt";


        private void AgregarVentaBaseLocal(Venta venta)
        {
            string docPath = rutaLocal;
            string nombreUsuarioSistema = Environment.UserName;
            string docPathAdaptado = docPath.Replace("USUARIOSISTEMA", nombreUsuarioSistema);

            StreamWriter writer = new StreamWriter(docPathAdaptado, true);

            try
            {
                Guid idVentaLocal = Guid.NewGuid();
                writer.WriteLine(venta.Id + "+" + venta.Cantidad + "+" + venta.FechaAlta + "+" + venta.Estado + "+" + idVentaLocal);
                //*Falta agregar de la grilla a la base local
            }

            catch
            {
                Console.WriteLine("error");
            }
            writer.Close();
        }

        public double DescuentoPrimerCompra(int dni,double importeResto, double importeElectro)
        {
            double descuento;
            NegocioCliente negocioCliente = new NegocioCliente();
            Cliente cliente = negocioCliente.BuscarCliente(dni);

            VentaService ventaService = new VentaService();
            List<Venta> ventasCliente= ventaService.TraerVenta(dni.ToString());

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
