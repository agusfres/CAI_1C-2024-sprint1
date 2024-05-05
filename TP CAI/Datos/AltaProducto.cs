using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class AltaProducto
    {
        int idCategoria;
        Guid idUsuario;
        Guid idProveedor;
        string nombre;
        double precio;
        int stock;


        public AltaProducto(int idCategoria, Guid idUsuario, Guid idProveedor, string nombre, double precio, int stock)
        {
            this.idCategoria = idCategoria;
            this.idUsuario = idUsuario;
            this.idProveedor = idProveedor;
            this.nombre = nombre;
            this.precio = precio;
            this.stock = stock;
        }


        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public Guid IdUsuario { get => idUsuario; set => idUsuario = value; }
        public Guid IdProveedor { get => idProveedor; set => idProveedor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
