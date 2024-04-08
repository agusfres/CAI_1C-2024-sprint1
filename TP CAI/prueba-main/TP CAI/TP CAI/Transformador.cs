using System;


namespace TP_CAI
{
	internal class Transformador
	{
        public int transformarStringInt(string texto)
        {
            int salida;
            if (int.TryParse(texto, out salida))
            {
                return salida;
            }
            return -1;
        }


        public DateTime transformarStringDatetime(string texto)
        {
            DateTime salida;
            if (DateTime.TryParseExact(texto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out salida))
            {
                return salida;
            }
            return DateTime.Now;
        }
    }
}

