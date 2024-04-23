using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class ModificarProducto
    {
        Guid id;
        Guid idUsuario;
        int precio;
        int stock;


        public ModificarProducto(Guid id, Guid idUsuario, int precio, int stock)
        {
            this.id = id;
            this.idUsuario = idUsuario;
            this.precio = precio;
            this.stock = stock;
        }


        public Guid Id { get => id; set => id = value; }
        public Guid IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
