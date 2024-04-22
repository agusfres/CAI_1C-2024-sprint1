using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Presentacion2
{
    internal class Validador
    {
        public void ValidarNombreUsuario(string usuario, string nombre, string apellido, string campo, ref string error)
        {
            string msgError = "";
            msgError = msgError + ValidarLongitud(usuario, campo, 8, 15);
            msgError = msgError + ValidarUsuario(usuario, nombre, apellido);
            error = msgError;
        }


        public void ValidarContraseña(string texto, string campo, ref string error)
        {
            string msgError = "";
            msgError = msgError + ValidarLongitud(texto, campo, 8, 15);
            msgError = msgError + ValidarFormatoContraseña(texto);
            msgError = msgError + ValidarContraseñaDefinitiva(texto);
            error = msgError;
        }


        private string ValidarFormatoContraseña(string texto)
        {
            bool flag1 = ValidarNumeroContra(texto);
            bool flag2 = ValidarMayusculaContra(texto);

            if (flag1 == true && flag2 == true)
            {
                return "";
            }
            return "La contraseña debe contener al menos una mayúscula y un número. " + System.Environment.NewLine;
        }


        private bool ValidarNumeroContra(string texto)
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


        private string ValidarContraseñaDefinitiva(string texto)
        {
            if (texto == "CAI20232")
            {
                return "Su contraseña debe ser diferente";
            }
            return "";
        }


        public string ValidarContraseñaDefinitivaLogin(string texto)
        {
            if (texto != "CAI20232")
            {
                return "Debe cambiar su contraseña";
            }
            return "";
        }


        private bool ValidarMayusculaContra(string texto)
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


        private string ValidarUsuario(string usuario, string nombre, string apellido)
        {
            if (usuario.Contains(nombre) || usuario.Contains(apellido))
            {
                return "El usuario no debe contener nombre y/o apellido. " + System.Environment.NewLine;
            }
            return "";
        }


        private string ValidarLongitud(string texto, string campo, int min, int max)
        {
            if (texto.Length < min || texto.Length > max)
            {
                return "El campo " + campo + " debe tener entre " + min + " y " + max + " caracteres." + System.Environment.NewLine;
            }
            return "";
        }


        public string ValidarVacio(string texto, string campo)
        {
            if (texto.Length == 0)
            {
                return "El campo " + campo + " no debe estar vacío. " + System.Environment.NewLine;
            }
            return "";
        }


        public void ValidarTextoUno(string texto, string campo, ref string error)
        {
            string msgError = "";
            msgError = msgError + ValidarLongitud(texto, campo, 1, 50);

            if (ValidarContieneNumeros(texto))
            {
                msgError += "El campo " + campo + " no debe contener números." + System.Environment.NewLine;
            }

            error = msgError;
        }

        private bool ValidarContieneNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }


        public void ValidarTextoDos(string texto, string campo, ref string error)
        {
            string msgError = "";
            msgError = msgError + ValidarLongitud(texto, campo, 1, 255);

            if (campo == "Email")
            {
                if (texto.Contains("@") && texto.IndexOf("@") > 0 && texto.LastIndexOf("@") < texto.Length - 1)
                {
                    msgError = msgError + "";
                }
                else
                {
                    msgError = msgError + "El campo " + campo + " debe ser una dirección de email." + System.Environment.NewLine;
                }
            }

            error = msgError;
        }


        public void ValidarDNI(string texto, string campo, ref string error)
        {
            string msgError = "";
            msgError = msgError + ValidarLongitud(texto, campo, 1, 8);
            msgError = msgError + ValidarFormatoNumero(texto, campo);
            error = msgError;
        }


        public void ValidarTelefono(string texto, string campo, ref string error)
        {
            string msgError = "";
            msgError = msgError + ValidarLongitud(texto, campo, 8, 10);
            msgError = msgError + ValidarFormatoNumero(texto, campo);
            error = msgError;
        }


        private string ValidarFormatoNumero(string texto, string campo)
        {
            if (!int.TryParse(texto, out int numero))
            {
                return "El campo " + campo + " debe contener únicamente números." + System.Environment.NewLine;
            }
            return "";
        }


        public void ValidarFecha(string texto, string campo, ref string error, ref DateTime salida)
        {
            string msgError = "";
            msgError = msgError + ValidarVacio(texto, campo);
            msgError = msgError + ValidarFormatoFecha(texto, campo, ref salida);
            error = msgError;
        }


        private string ValidarFormatoFecha(string texto, string campo, ref DateTime salida)
        {
            if (!DateTime.TryParseExact(texto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out salida))
            {
                return "El campo " + campo + " debe cumplir el formato DD/MM/AAAA." + System.Environment.NewLine;
            }
            else if (salida > DateTime.Today || salida < new DateTime(1924, 1, 1))
            {
                return "El campo " + campo + " debe ser una fecha válida." + System.Environment.NewLine;
            }
            else if (!ValidarEsMayorDeEdad(salida))
            {
                return "Debe ser mayor de 18 años para registrarse." + System.Environment.NewLine;
            }
            return "";
        }


        public bool ValidarEsMayorDeEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Today.Year - fechaNacimiento.Year;

            // Resta un año si aún no ha pasado el cumpleaños de este año
            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad))
            {
                edad--;
            }

            return edad >= 18;
        }


        public void ValidarTipoUsuario(string texto, string campo, ref string error)
        {
            string msgError = "";
            List<string> opciones = new List<string>() { "1. Vendedor ", "2. Supervisor ", "3. Administrador " };
            msgError = msgError + ValidarVacio(texto, campo);
            if (!opciones.Contains(texto))
            {
                msgError = msgError + "El campo " + campo + " debe ser alguna de las opciones indicadas, no escribir." + System.Environment.NewLine;
            }
            error = msgError;
        }
    }
}
