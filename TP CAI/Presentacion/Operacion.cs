using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class Operacion
    {
        public Guid TransformarStringGuid(string texto)
        {
            if (Guid.TryParse(texto, out Guid salida))
            {
                return salida;
            }
            return Guid.Empty;
        }
        public DateTime TransformarStringDatetime(string texto)
        {
            DateTime salida;

            if (DateTime.TryParse(texto, out salida))
            {
                return salida;
            }
            return salida;
        }
        public int TransformarStringInt(string texto)
        {
            if (int.TryParse(texto, out int salida))
            {
                return salida;
            }
            return -1;
        }
    }

}
