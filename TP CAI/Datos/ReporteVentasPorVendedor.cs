using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Datos
{
    public class ReporteVentasPorVendedor
    {
        string nombre;
        int cantidadVentas;
        double montoTotal;

        public ReporteVentasPorVendedor(string nombre, int cantidadVentas, double montoTotal)
        {
            this.nombre = nombre;
            this.cantidadVentas = cantidadVentas;
            this.montoTotal = montoTotal;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int CantidadVentas { get => cantidadVentas; set => cantidadVentas = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }
    }
}
