using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Producto
    {
        Guid id;
        int idCategoria;
        string nombre;
        DateTime fechaAlta;
        DateTime? fechaBaja;
        double precio;
        int stock;
        Guid idUsuario;
        Guid idProveedor;


        public Producto(Guid id, int idCategoria, string nombre, DateTime fechaAlta, DateTime? fechaBaja, double precio, int stock, Guid idUsuario, Guid idProveedor)
        {
            this.id = id;
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.fechaAlta = fechaAlta;
            this.fechaBaja = fechaBaja;
            this.precio = precio;
            this.stock = stock;
            this.idUsuario = idUsuario;
            this.idProveedor = idProveedor;
        }


        public Guid IdProducto { get => id; set => id = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public DateTime? FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public Guid IdUsuario { get => idUsuario; set => idUsuario = value; }
        public Guid IdProveedor { get => idProveedor; set => idProveedor = value; }

    }
}

