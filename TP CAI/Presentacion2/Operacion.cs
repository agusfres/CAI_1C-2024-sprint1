using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Presentacion2
{
    internal class Operacion
    {
        public int TransformarStringInt(string texto)
        {
            int salida;
            if (int.TryParse(texto, out salida))
            {
                return salida;
            }
            return -1;
        }


        public DateTime TransformarStringDatetime(string texto)
        {
            DateTime salida;
            if (DateTime.TryParseExact(texto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out salida))
            {
                return salida;
            }
            return DateTime.Now;
        }

        public Guid TransformarStringGuid(string texto)
        {
            Guid salida;
            if (Guid.TryParse(texto, out salida))
            {
                return salida;
            }
            return Guid.Empty;
        }
    }
}

