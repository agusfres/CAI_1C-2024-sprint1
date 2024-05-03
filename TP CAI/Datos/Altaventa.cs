using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Altaventa
    {
        Guid idCliente;
        Guid idUsuario;
        Guid idProducto;
        int cantidad;


        public Altaventa(Guid idCliente, Guid idUsuario, Guid idProducto, int cantidad)
        {
            this.idCliente = idCliente;
            this.idUsuario = idUsuario;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
        }


        public int IdCliente { get => IdCliente; set => IdCliente = value; }
        public Guid IdUsuario { get => idUsuario; set => idUsuario = value; }
        public Guid IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}

