using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Datos
{
    public class ReporteStock
    {
        Guid id;
        string nombre;
        int stock;
        double precio;

        public ReporteStock(Guid id, string nombre, int stock, double precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.stock = stock;
            this.precio = precio;
        }

        public Guid Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Stock { get => stock; set => stock = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
