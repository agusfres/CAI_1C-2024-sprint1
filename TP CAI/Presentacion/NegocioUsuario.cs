﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Persistencia;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using Negocio;
using Presentacion;

namespace Negocio
{
    public class NegocioUsuario
    {
        private UsuarioService usuarioService = new UsuarioService();
        private Guid idAdministrador = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        string rutaLocal = @"C:\Users\USUARIOSISTEMA\OneDrive\Documentos\GitHub\CAI_1C-2024-sprint1\TP CAI\UsuariosLocales.txt";


        public void AgregarUsuario(string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaNacimiento, string nombreUsuario, int tipoUsuario, int dni, string contraseña)
        {
            // Ponemos host como 1 ya que al usar 5 el web service da error 409 porqu solo permite un enum de 1, 2 o 3
            int host = 1;
            AltaUsuario altaUsuario = new AltaUsuario(idAdministrador, host, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, nombreUsuario, contraseña);
            usuarioService.AgregarUsuario(altaUsuario);
            Usuario usuarioAuxiliar = BuscarUsuario(nombreUsuario);
            Usuario usuario = new Usuario(usuarioAuxiliar.Id, nombre, apellido, direccion, telefono, email, DateTime.Now, fechaNacimiento, null, null, nombreUsuario, tipoUsuario, dni, contraseña, host,"INACTIVO");
            AgregarUsuarioBaseLocal(usuario);
        }


        public Usuario BuscarUsuario(string nombreUsuario)
        {
            List<Usuario> listaUsuarios = TraerUsuariosActivos();

            if (listaUsuarios != null)
            {
                foreach (Usuario usuario in listaUsuarios)
                {
                    if (usuario.NombreUsuario == nombreUsuario)
                    {
                        return usuario;
                    }
                }
            }
            return null;
        }


        public List<Usuario> TraerUsuariosActivos()
        {
            return usuarioService.TraerUsuariosActivos(idAdministrador);
        }


        public void BorrarUsuario(Guid idUsuario)
        {
            BajaUsuario bajaUsuario = new BajaUsuario(idUsuario, idAdministrador);
            usuarioService.BorrarUsuario(bajaUsuario);
            ModificarEstadoBaseLocal(idUsuario);
        }


        public void CambiarContraseña(string nombreUsuarioActual, string contraseñaActual, string contraseñaNueva)
        {
            UsuarioService.CambiarContraseña(nombreUsuarioActual, contraseñaActual, contraseñaNueva);
            ModificarContraseñaEstadoBaseLocal(nombreUsuarioActual, contraseñaNueva);
        }


        private void AgregarUsuarioBaseLocal(Usuario usuario)
        {
            string docPath = rutaLocal;
            string nombreUsuarioSistema = Environment.UserName;
            string docPathAdaptado = docPath.Replace("USUARIOSISTEMA", nombreUsuarioSistema);
           
            StreamWriter writer = new StreamWriter(docPathAdaptado, true);

            try
            {
                writer.WriteLine(usuario.Id + "+" + usuario.Nombre + "+" + usuario.Apellido + "+" + usuario.Direccion + "+" + usuario.Telefono + "+" + usuario.Email + "+" + usuario.FechaAlta + "+" + usuario.FechaNacimiento + "+null+null+" + usuario.NombreUsuario + "+" + usuario.TipoUsuario + "+" + usuario.Dni + "+" + usuario.Contraseña + "+" + usuario.Host + "+" + usuario.Estado);
            }
            catch
            {
                Console.WriteLine("error");
            }
            writer.Close();
        }


        private void ModificarContraseñaEstadoBaseLocal(string usuario,string contraseña)
        {
            string docPath = rutaLocal;
            string nombreUsuarioSistema = Environment.UserName;
            string docPathAdaptado = docPath.Replace("USUARIOSISTEMA", nombreUsuarioSistema);
            string tempPath = Path.GetTempFileName(); // Ruta temporal para escribir el contenido actualizado

            StreamReader sr = new StreamReader(docPathAdaptado);
            StreamWriter sw = new StreamWriter(tempPath);
            string linea;
            while ((linea = sr.ReadLine()) != null)
            {
                string[] vector = linea.Split('+');
                // Si la línea actual no coincide con la línea que deseas eliminar, escríbela en el archivo temporal
                if (vector[10] != usuario)
                {
                    sw.WriteLine(linea);
                }
                else
                {
                    try 
                    {
                        string id = vector[0];
                        string nombre = vector[1];
                        string apellido = vector[2];
                        string direccion = vector[3];
                        string telefono = vector[4];
                        string email = vector[5];
                        string fechaAlta = vector[6];
                        string fechaNacimiento = vector[7];
                        string fechaBaja = vector[8];
                        string fechaUltAct = DateTime.Now.ToString();
                        string tipoUsuario = vector[11];
                        string dni = vector[12];
                        string host = vector[14];

                        sw.WriteLine(id + '+' + nombre + '+' + apellido + '+' + direccion + '+' + telefono + '+' + email + '+' + fechaAlta + '+' + fechaNacimiento + '+' + fechaBaja + '+' + DateTime.Now + '+' + usuario + '+' + tipoUsuario + '+' + dni + '+' + contraseña + '+' + host + "+ACTIVO");
                    }
                    catch { Console.WriteLine("Error");  }
                }
            }
            sw.Close();
            sr.Close();
            // Reemplaza el archivo original con el archivo temporal
            System.IO.File.Delete(docPathAdaptado);
            System.IO.File.Move(tempPath, docPathAdaptado);
            // Borra el archivo temporal
            System.IO.File.Delete(tempPath);
        }


        public void ModificarEstadoBaseLocal(Guid idUsuario)
        {
            string docPath = rutaLocal;
            string nombreUsuarioSistema = Environment.UserName;
            string docPathAdaptado = docPath.Replace("USUARIOSISTEMA", nombreUsuarioSistema);
            string tempPath = Path.GetTempFileName(); // Ruta temporal para escribir el contenido actualizado

            StreamReader sr = new StreamReader(docPathAdaptado);
            StreamWriter sw = new StreamWriter(tempPath);
            string linea;
            while ((linea = sr.ReadLine()) != null)
            {
                string[] vector = linea.Split('+');
                // Si la línea actual no coincide con la línea que deseas eliminar, escríbela en el archivo temporal
                if (vector[0] != idUsuario.ToString())
                {
                    sw.WriteLine(linea);
                }
                else
                {
                    try
                    {
                        string id = vector[0];
                        string nombre = vector[1];
                        string apellido = vector[2];
                        string direccion = vector[3];
                        string telefono = vector[4];
                        string email = vector[5];
                        string fechaAlta = vector[6];
                        string fechaNacimiento = vector[7];
                        string fechaBaja = vector[8];
                        string fechaUltAct = vector[9];
                        string nombreUsuario = vector[10];
                        string tipoUsuario = vector[11];
                        string dni = vector[12];
                        string contraseña = vector[13];
                        string host = vector[14];

                        sw.WriteLine(id + '+' + nombre + '+' + apellido + '+' + direccion + '+' + telefono + '+' + email + '+' + fechaAlta + '+' + fechaNacimiento + '+' + DateTime.Now + '+' + fechaUltAct + '+' + nombreUsuario + '+' + tipoUsuario + '+' + dni + '+' + contraseña + '+' + host + "+INACTIVO");
                    }
                    catch { Console.WriteLine("Error"); }
                }
            }
            sw.Close();
            sr.Close();
            // Reemplaza el archivo original con el archivo temporal
            System.IO.File.Delete(docPathAdaptado);
            System.IO.File.Move(tempPath, docPathAdaptado);
            // Borra el archivo temporal
            System.IO.File.Delete(tempPath);
        }

        public Usuario BuscarUsuarioBaseLocal(string nombreUsuario_)
        {
            string docPath = rutaLocal;
            string nombreUsuarioSistema = Environment.UserName;
            string docPathAdaptado = docPath.Replace("USUARIOSISTEMA", nombreUsuarioSistema);

            StreamReader sr = new StreamReader(docPathAdaptado);
            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                string[] vector = linea.Split('+');
                // Si la línea actual no coincide con la línea que deseas eliminar, escríbela en el archivo temporal
                if (vector[10] == nombreUsuario_)
                {
                    string id = vector[0];
                    string nombre = vector[1];
                    string apellido = vector[2];
                    string direccion = vector[3];
                    string telefono = vector[4];
                    string email = vector[5];
                    string fechaAlta = vector[6];
                    string fechaNacimiento = vector[7];
                    string fechaBaja = vector[8];
                    string fechaUltAct = vector[9];
                    string nombreUsuario = vector[10];
                    string tipoUsuario = vector[11];
                    string dni = vector[12];
                    string contraseña = vector[13];
                    string host = vector[14];
                    string estado = vector[15];

                    Operacion operacion = new Operacion();
                    Guid idTransformado = operacion.TransformarStringGuid(id);
                    DateTime fechaAltaTransformada = operacion.TransformarStringDatetime(fechaAlta);
                    DateTime fechaNacimientoTransformada = operacion.TransformarStringDatetime(fechaNacimiento);
                    DateTime fechaBajaTransformada = operacion.TransformarStringDatetime(fechaBaja);
                    DateTime fechaUltimaActTransformada = operacion.TransformarStringDatetime(fechaUltAct);

                    int tipoUsuarioTransformada = operacion.TransformarStringInt(tipoUsuario);
                    int dniTransformada = operacion.TransformarStringInt(dni);
                    int hostTransformada = operacion.TransformarStringInt(host);

                    Usuario usuario = new Usuario(idTransformado, nombre, apellido, direccion, telefono, email, fechaAltaTransformada, fechaNacimientoTransformada, fechaBajaTransformada, fechaUltimaActTransformada, nombreUsuario, tipoUsuarioTransformada, dniTransformada, contraseña, hostTransformada, estado);
                    sr.Close();
                    return usuario;
                }
            }
            sr.Close();
            return null;
        }
    }
}