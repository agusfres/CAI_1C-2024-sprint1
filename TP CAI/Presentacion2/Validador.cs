using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Presentacion2
{
    internal class Validador
    {
        private string ValidarLongitud(string texto, string campo, int min, int max)
        {
            if (texto.Length < min || texto.Length > max)
            {
                return "El campo " + campo + " debe tener entre " + min + " y " + max + " caracteres." + System.Environment.NewLine;
            }
            return "";
        }


        private bool ValidarContieneCaracteresEspeciales(string texto)
        {
            List<char> caracteresEspeciales = new List<char> { 'Á', 'É', 'Í', 'Ó', 'Ú', 'Ü', 'Ñ', 'Ç', 'á', 'é', 'í', 'ó', 'ú', 'ü', 'ñ', '\'' };

            foreach (char c in texto)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c) && !caracteresEspeciales.Contains(c))
                {
                    return true;
                }
            }
            return false;
        }


        public string ValidarVacio(string texto, string campo)
        {
            if (texto.Length == 0)
            {
                return "El campo " + campo + " no debe estar vacío. " + System.Environment.NewLine;
            }
            return "";
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


        public string ValidarNombre(string texto, string campo)
        {
            string msgError = "";
            msgError += ValidarLongitud(texto, campo, 2, 40);

            if (ValidarContieneNumeros(texto))
            {
                msgError += "El campo " + campo + " no debe contener números." + System.Environment.NewLine;
            }
            if (ValidarContieneCaracteresEspeciales(texto))
            {
                msgError += "El campo " + campo + " no debe contener caracteres especiales." + System.Environment.NewLine;
            }
            if (ValidarContieneCaracteresEspeciales(texto))
            {
                msgError += "El campo " + campo + " no debe contener caracteres especiales." + System.Environment.NewLine;
            }

            return msgError;
        }


        public string ValidarDireccion(string texto, string campo)
        {
            string msgError = "";
            Regex regex = new Regex(@"\d.*[a-zA-Z]|[a-zA-Z].*\d");

            if (!regex.IsMatch(texto))
            {
                msgError += "El campo " + campo + " no es válido, intente nuevamente." + System.Environment.NewLine;
            }

            return msgError;
        }


        public string ValidarTelefono(string texto, string campo)
        {
            string msgError = "";
            msgError += ValidarLongitud(texto, campo, 8, 10);
            msgError += ValidarFormatoNumero(texto, campo);
            return msgError;
        }


        public string ValidarEmail(string texto, string campo)
        {
            string msgError = "";
            msgError += ValidarLongitud(texto, campo, 5, 40);

            if (texto.Contains("@") && texto.IndexOf("@") > 0 && texto.LastIndexOf("@") < texto.Length - 1)
            {
                msgError += "";
            }
            else
            {
                msgError += "El campo " + campo + " debe ser una dirección de email." + System.Environment.NewLine;
            }

            return msgError;
        }


        public string ValidarFecha(string texto, string campo)
        {
            string msgError = "";
            msgError += ValidarVacio(texto, campo);
            msgError += ValidarFormatoFecha(texto, campo);
            return msgError;
        }


        private string ValidarFormatoFecha(string texto, string campo)
        {
            string msgError = "";

            if (!DateTime.TryParseExact(texto, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime salida))
            {
                msgError += "El campo " + campo + " debe cumplir el formato DD/MM/AAAA." + System.Environment.NewLine;
            }
            else if (salida > DateTime.Today)
            {
                msgError += "El campo " + campo + " no puede ser una fecha futura." + System.Environment.NewLine;
            }
            else if (salida < new DateTime(1924, 1, 1))
            {
                msgError += "El campo " + campo + " no puede ser tan antiguo." + System.Environment.NewLine;
            }
            else if (!ValidarEsMayorDeEdad(salida))
            {
                msgError += "Debe ser mayor de 18 años para registrarse." + System.Environment.NewLine;
            }

            return msgError;
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


        public string ValidarNombreUsuario(string usuario, string nombre, string apellido, string campo)
        {
            string msgError = "";
            msgError += ValidarLongitud(usuario, campo, 8, 15);
            msgError += ValidarUsuario(usuario, nombre, apellido);
            return msgError;
        }


        public string ValidarContraseña(string contraseña)
        {
            string msgError = "";
            bool contieneNumero = false;
            bool contieneMayuscula = false;

            msgError += ValidarVacio(contraseña, "contraseña");

            foreach (char c in contraseña)
            {
                if (char.IsDigit(c))
                {
                    contieneNumero = true;
                }
                if (char.IsUpper(c))
                {
                    contieneMayuscula = true;
                }
            }
            if (!contieneNumero || !contieneMayuscula)
            {
                msgError += "La contraseña debe contener al menos una mayúscula y un número." + Environment.NewLine;
            }
            if (contraseña == "CAI20232")
            {
                msgError += "Debe modificar la contraseña ya que no puede usar esa." + Environment.NewLine;
            }

            return msgError;
        }


        private string ValidarUsuario(string usuario, string nombre, string apellido)
        {
            usuario = usuario.ToLower();
            nombre = nombre.ToLower();
            apellido = apellido.ToLower();

            if (usuario.Contains(nombre) || usuario.Contains(apellido))
            {
                return "El usuario no debe contener nombre y/o apellido. " + System.Environment.NewLine;
            }

            return "";
        }


        public string ValidarDNI(string texto, string campo)
        {
            string msgError = "";
            msgError += ValidarLongitud(texto, campo, 6, 9);
            msgError += ValidarFormatoNumero(texto, campo);
            return msgError;
        }


        private string ValidarFormatoNumero(string texto, string campo)
        {
            if (!long.TryParse(texto, out _))
            {
                return "El campo " + campo + " debe contener únicamente números." + System.Environment.NewLine;
            }

            return "";
        }


        public string ValidarTipoUsuario(string texto, string campo)
        {
            string msgError = "";
            List<string> opciones = new List<string>() { "1. Vendedor ", "2. Supervisor ", "3. Administrador " };
            msgError += ValidarVacio(texto, campo);
            
            if (!opciones.Contains(texto))
            {
                msgError += "El campo " + campo + " debe ser alguna de las opciones indicadas." + System.Environment.NewLine;
            }

            return msgError;
        }
    }
}
