﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Presentacion;


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


        public string ValidarCuit(string cuit, string campo)
        {
            string msgError = "";
            if (cuit.Length != 11)
            {
                msgError += "El campo CUIT debe tener 11 dígitos." + System.Environment.NewLine;
            }
            msgError += ValidarFormatoNumero(cuit, campo);
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


        public string ValidarDato(string dato, string nombre, string apellido, string campo)
        {
            string msgError = "";
            msgError += ValidarLongitud(dato, campo, 8, 15);
            msgError += ValidarUsuario(dato, nombre, apellido);
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
            msgError += ValidarLongitud(texto, campo, 7, 8);
            msgError += ValidarFormatoNumero(texto, campo);

            return msgError;
        }


        public string ValidarDNIExistente(string texto, string campo)
        {
            string msgError = "";
            msgError += ValidarLongitud(texto, campo, 7, 8);
            msgError += ValidarFormatoNumero(texto, campo);

            if (msgError == "")
            {
                Operacion operacion = new Operacion();
                int dni = operacion.TransformarStringInt(texto);
                NegocioCliente negocio = new NegocioCliente();
                Cliente cliente = negocio.BuscarCliente(dni);
                if (cliente == null)
                {
                    msgError = "El cliente ingresado no existe.";
                }
            }

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


        private string ValidarFormatoGuid(string texto, string campo)
        {
            if (!Guid.TryParse(texto, out _))
            {
                return "El campo " + campo + " es inválido." + System.Environment.NewLine;
            }
            return "";
        }


        private string ValidarPositivo(string texto, string campo)
        {
            if (double.TryParse(texto, out double numero))
            {
                if (numero > 0)
                {
                    return "";
                }
            }
            return "El campo " + campo + " no puede ser negativo." + System.Environment.NewLine; ;
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


        public string ValidarCategoriaProducto1(CheckedListBox ListbxCategorias)
        {
            string msgError = "";
            if (ListbxCategorias.CheckedItems.Count == 0)
            {
                msgError += "Debe seleccionar al menos una categoría";
            }
            return msgError;
        }


        public string ValidarCategoriaProducto2(string texto, string campo)
        {
            string msgError = "";
            List<string> opciones = new List<string>() { "1. Audio ","2. Celulares ","3. Electro Hogar ","4. Informática ","5. Smart TV " };
            msgError += ValidarVacio(texto, campo);

            if (!opciones.Contains(texto))
            {
                msgError += "El campo " + campo + " debe ser alguna de las opciones indicadas." + System.Environment.NewLine;
            }

            return msgError;
        }


        public string ValidarNombreProducto(string texto, string campo)
        {
            string msgError = "";
            msgError += ValidarLongitud(texto, campo, 2, 50);

            return msgError;
        }


        public string ValidarStockPrecio(string texto, string campo)
        {
            string msgError = "";
            msgError += ValidarVacio(texto, campo);
            msgError += ValidarFormatoNumero(texto, campo);
            msgError += ValidarPositivo(texto, campo);
            return msgError;
        }


        public string ValidarIdProveedor(string texto, string campo)
        {
            string msgError = "";
            msgError += ValidarVacio(texto, campo);
            return msgError;
        }

        public string ValidarIdVenta(string texto, string campo)
        {
            string msgError = "";
            msgError += ValidarVacio(texto, campo);
            msgError += ValidarFormatoGuid(texto, campo);
            
            if(msgError == "")
            {
                NegocioVenta negocioVenta = new NegocioVenta();
                msgError = negocioVenta.BuscarVentaBaseLocal(texto);
            }

            
            return msgError;

        }


        /* LO DEJO COMENTADO PORQUE NO SE COMO COMBOBOX DE LA API
       public string ValidarProducto(string texto, string campo)
        {
            string msgError = "";
            List<string> opciones = new List<string>();
            msgError += ValidarVacio(texto, campo);

            if (!opciones.Contains(texto))
            {
                msgError += "El campo " + campo + " debe ser alguna de las opciones indicadas." + System.Environment.NewLine;
            }
            return msgError;
        }
        */

        public string ValidarCantidadProd(string cantidad, string campo,int stock,List<CarritoProducto> carrito)
        {
            string msgError = "";
            msgError += ValidarVacio(cantidad, campo);
            msgError += ValidarFormatoNumero(cantidad, campo);
            Operacion operacion = new Operacion();
            int cantidadInt = operacion.TransformarStringInt(cantidad);
            if (msgError == "")
            {
                if(cantidadInt > stock)
                {
                    msgError += "La cantidad debe ser igual o menor al stock: " + stock;
                }
            }
            return msgError;
        }


        public string ValidarComboBox(string texto, string campo)
        {
            string msgError = "";
            msgError += ValidarVacio(texto, campo);

            return msgError;
        }


        public string ValidarEstado(string texto, string campo)
        {
            string msgError = "";
            msgError += ValidarVacio(texto, campo);
            texto.ToUpper();
            if (texto != "ACTIVO" && texto != "INACTIVO")
            {
                msgError += "El campo " + campo + " debe ser ACTIVO o INACTIVO." + System.Environment.NewLine;
            }
            return msgError;
        }


        public string ValidarMes(string texto, string campo)
        {
            string msgError = "";
            List<string> opciones = new List<string>() { "Enero ", "Febrero ", "Marzo ", "Abril ", "Mayo ", "Junio ", "Julio ", "Agosto ", "Septiembre ", "Octubre ", "Noviembre ", "Diciembre " };
            msgError += ValidarVacio(texto, campo);

            if (!opciones.Contains(texto))
            {
                msgError += "El campo " + campo + " debe ser alguna de las opciones indicadas." + System.Environment.NewLine;
            }

            return msgError;
        }
    }
}
