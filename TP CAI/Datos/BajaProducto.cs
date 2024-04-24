using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class BajaProducto
    {
        Guid id;
        Guid idUsuario;


        public BajaProducto(Guid id, Guid idUsuario)
        {
            this.id = id;
            this.idUsuario = idUsuario;
        }


        public Guid Id { get => id; set => id = value; }
        public Guid IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
