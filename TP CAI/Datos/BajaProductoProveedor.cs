using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class BajaProductoProveedor
    {
        //Usamos la misma clase para producto y proveedor porque son idénticas en cuanto a lo que tienen y hacen
        Guid id;
        Guid idUsuario;


        public BajaProductoProveedor(Guid id, Guid idUsuario)
        {
            this.id = id;
            this.idUsuario = idUsuario;
        }


        public Guid Id { get => id; set => id = value; }
        public Guid IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
