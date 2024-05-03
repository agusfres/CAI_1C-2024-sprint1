using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class Venta
    {
        Guid id;
        int cantidad;
        DateTime fechaAlta;
        int estado;


        public Venta(Guid id, int cantidad, DateTime fechaAlta, int estado)
        {
            this.id = id;
            this.cantidad = cantidad;
            this.fechaAlta = fechaAlta;
            this.estado = estado;
        }


        public Guid Id { get => id; set => id = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public int Estado { get => estado; set => cantidad = estado; }
    }
}
