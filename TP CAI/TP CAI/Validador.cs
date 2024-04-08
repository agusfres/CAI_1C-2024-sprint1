using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_CAI
{
    internal class Validador
    {
        public void validarNombreUsuario(string usuario, string nombre, string apellido, string campo, ref string error)
        {
            string msgError = "";
            msgError = msgError + validarLongitud(usuario, campo, 8, 15);
            msgError = msgError + validarUsuario(usuario, nombre, apellido, campo);
            error = msgError;
        }


        public void validarContrasena(string texto, string campo, ref string error)
        {
            string msgError = "";
            msgError = msgError + validarLongitud(texto, campo, 8, 15);
            msgError = msgError + validarFormatoContrasena(texto, campo);
            error = msgError;
        }


        private string validarFormatoContrasena(string texto, string campo)
        {
            bool flag1 = validarNumeroContra(texto);
            bool flag2 = validarMayusculaContra(texto);

            if (flag1 == true && flag2 == true)
            {
                return "";
            }
            return "El campo " + campo + " debe contener al menos una mayúscula y un número ";
        }


        private bool validarNumeroContra(string texto)
        {
            bool flag1 = false;
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    flag1 = true;
                    break;
                }
                else
                {
                    flag1 = false;
                }
            }
            return flag1;
        }


        private bool validarMayusculaContra(string texto)
        {
            bool flag2 = false;
            foreach (char c in texto)
            {
                if (char.IsUpper(c))
                {
                    flag2 = true;
                    break;
                }
                else
                {
                    flag2 = false;
                }
            }
            return flag2;
        }


        private string validarUsuario(string usuario, string nombre, string apellido, string campo)
        {
            if (usuario.Contains(nombre) || usuario.Contains(apellido))
            {
                return "El campo " + campo + " no debe contener nombre y/o apellido ";
            }
            return "";
        }


        private string validarLongitud(string texto, string campo, int min , int max)
        {
            if (texto.Length < min || texto.Length > max)
            {
                return "El campo " + campo + " debe tener entre " + min + " y " + max + ".";
            }
            return "";
        }


        private string validarVacio(string texto, string campo)
        {
            if (texto.Length == 0 )
            {
                return "El campo " + campo + " no debe estar vacío. ";
            }
            return "";
        }


        public void validarTextoUno(string texto, string campo , ref string error)
        {
            string msgError = "";
            msgError = msgError + validarLongitud(texto, campo, 1, 50);
            error = msgError;
        }


        public void validarTextoDos(string texto, string campo, ref string error)
        {
            string msgError = "";
            msgError = msgError + validarLongitud(texto, campo, 1, 255);

            if (campo == "Email")
            {
                if (texto.Contains("@"))
                {
                    msgError = msgError + "";
                }
                else
                {
                    msgError = msgError + "El campo " + campo + " debe ser una dirección de email.";
                }
            }

            error = msgError;
        }


        public void validarDNI(string texto, string campo, ref string error)
        {
            string msgError = "";
            msgError = msgError + validarLongitud(texto, campo, 1, 8);
            msgError = msgError + validarFormatoNumero(texto, campo);
            error = msgError;
        }


        private string validarFormatoNumero(string texto, string campo)
        {
            if (!int.TryParse(texto, out int numero))
            {
                return "El campo " + campo + " debe contener únicamente números.";
            }
            return "";
        }


        public void validarFecha(string texto, string campo, ref string error, ref DateTime salida)
        {
            string msgError = "";
            msgError = msgError + validarVacio(texto, campo);
            msgError = msgError + validarFormatoFecha(texto, campo,ref salida);
            error = msgError;
        }


        private string validarFormatoFecha(string texto, string campo, ref DateTime salida)
        {
            if (!DateTime.TryParseExact(texto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out salida))
            {
                return "El campo " + campo + " debe cumplir el formato DD/MM/AAAA.";
            }
            else if (salida > DateTime.Today || salida < new DateTime(1924, 1, 1))
            {
                return "El campo " + campo + " debe ser una fecha válida.";
             }
            return "" ;
        }


        public void validarTipoUsuario(string texto, string campo, ref string error)
        {
            string msgError = "";
            List<string> opciones = new List<string>() {"1. Vendedor ", "2. Supervisor ", "3. Vendedor "};
            msgError = msgError + validarVacio(texto, campo);
            if (!opciones.Contains(texto))
            {
                msgError = msgError + "El campo " + campo + " debe ser alguna de las opciones indicadas, no escribir";
            }
            error = msgError;
        }
    }
}





