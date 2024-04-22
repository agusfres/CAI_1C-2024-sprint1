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
            if (int.TryParse(texto, out int salida))
            {
                return salida;
            }
            return -1;
        }


        public DateTime TransformarStringDatetime(string texto)
        {
            if (DateTime.TryParseExact(texto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime salida))
            {
                return salida;
            }
            return DateTime.Now;
        }
    }
}

