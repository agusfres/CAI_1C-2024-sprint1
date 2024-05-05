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

        public double TransformarStringDouble(string texto)
        {
            if (double.TryParse(texto, out double salida))
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


        public int ObtenerTipoUsuario(string texto)
        {
            Dictionary<char, int> tipoUsuarioMapping = new Dictionary<char, int>
            {
                {'1', 1},
                {'2', 2},
                {'3', 3}
            };
            char primerCaracter = texto.FirstOrDefault();

            if (tipoUsuarioMapping.ContainsKey(primerCaracter))
            {
                return tipoUsuarioMapping[primerCaracter];
            }
            else
            {
                return -1;
            }
        }

    }
}