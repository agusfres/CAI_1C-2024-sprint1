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
