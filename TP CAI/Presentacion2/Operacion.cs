﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Presentacion2
{
    internal class Operacion
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


        public int asignarId(List<Usuario> usuarios)
        {
            int nuevoId = 1;
            List<int> idExistentes = new List<int>();
            foreach (Usuario usuario in usuarios)
            {
                idExistentes.Add(usuario.Id);
            }
            while (idExistentes.Contains(nuevoId))
            {
                nuevoId++;
            }
            return nuevoId;
        }


    }
}

