using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CarritoProducto
    {
        string nombre;
        double precio;
        int cantidad;
        int idCategoria;
        Guid idProducto;


        public CarritoProducto( string nombre, double precio, int cantidad,int idCategoria, Guid idProducto)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.idCategoria = idCategoria;
            this.idProducto = idProducto;
        }

       
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public Guid IdProducto { get => idProducto; set => idProducto = value; }
    }
}

