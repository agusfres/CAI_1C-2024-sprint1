using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentacion;

namespace Presentacion
{
    public class NegocioCliente
    {
        Operacion operacion = new Operacion();
        private ClienteService clienteService = new ClienteService();
        private Guid idUsuario = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        string docPathAdaptado = @"C:\Users\USUARIOSISTEMA\ClientesLocales.txt".Replace("USUARIOSISTEMA", Environment.UserName);


        public void AgregarCliente(string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaNacimiento,  int dni)
        {
            string host = "5";
            AltaCliente altaCliente = new AltaCliente(idUsuario, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, host);
            clienteService.AgregarCliente(altaCliente);

            Cliente clienteAuxiliar = BuscarCliente(dni);

            Cliente cliente = new Cliente(clienteAuxiliar.Id, nombre, apellido, direccion, telefono, email, DateTime.Now, fechaNacimiento, null, UsuarioLogueado.usuario.Id, host, dni, "ACTIVO");
            AgregarClienteBaseLocal(cliente);
        }


        public Cliente BuscarCliente(int dni)
        {
            List<Cliente> listaCliente = TraerClientes();

            if (listaCliente != null)
            {
                foreach (Cliente cliente in listaCliente)
                {
                    if (cliente.Dni == dni)
                    {
                        return cliente;
                    }
                }
            }

            return null;
        }


        public Cliente BuscarClienteBaseLocal(string dniCliente)
        {
            StreamReader sr = new StreamReader(docPathAdaptado);
            string linea;

            while ((linea = sr.ReadLine()) != null)
            {
                string[] vector = linea.Split('+');
                // Si la línea actual no coincide con la línea que deseas eliminar, escríbela en el archivo temporal
                if (vector[11] == dniCliente)
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
                    string idUsuario = vector[9];
                    string host = vector[10];
                    string dni = vector[11];
                    string estado = vector[12];

                    Guid idTransformado = operacion.TransformarStringGuid(id);
                    DateTime fechaAltaTransformada = operacion.TransformarStringDatetime(fechaAlta);
                    DateTime fechaNacimientoTransformada = operacion.TransformarStringDatetime(fechaNacimiento);
                    DateTime fechaBajaTransformada = operacion.TransformarStringDatetime(fechaBaja);
                    Guid idUsuarioTransformado = operacion.TransformarStringGuid(idUsuario);
                    int dniTransformada = operacion.TransformarStringInt(dni);

                    Cliente cliente = new Cliente(idTransformado, nombre, apellido, direccion, telefono, email, fechaAltaTransformada, fechaNacimientoTransformada, fechaBajaTransformada, idUsuarioTransformado, host, dniTransformada, estado);
                    sr.Close();
                    return cliente;
                }
            }

            sr.Close();
            return null;
        }


        public List<Cliente> TraerClientes()
        {
            List<Cliente> listaCliente = clienteService.GetClientes();
            return listaCliente;
        }


        private void AgregarClienteBaseLocal(Cliente cliente)
        {
            StreamWriter writer = new StreamWriter(docPathAdaptado, true);

            try
            {
                writer.WriteLine(cliente.Id + "+" + cliente.Nombre + "+" + cliente.Apellido + "+" + cliente.Direccion + "+" + cliente.Telefono + "+" + cliente.Email + "+" + cliente.FechaAlta + "+" + cliente.FechaNacimiento + "+null+" + cliente.IdUsuario + "+"  + cliente.Host + "+" + cliente.Dni + "+" + cliente.Estado);
            }
            catch
            {
                Console.WriteLine("error");
            }

            writer.Close();
        }


        public void ModificarCliente(Guid idUsuario, string telefono, string direccion, string estado, string email)
        {
            ClienteService.ModificarCliente(idUsuario.ToString(), telefono, direccion, email);
            ModificarClienteBaseLocal(idUsuario, telefono, direccion, estado, email);
        }


        public void ModificarClienteBaseLocal(Guid idUsuario, string telefono, string direccion, string estado, string email)
        {
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
                        string fechaAlta = vector[6];
                        string fechaNacimiento = vector[7];
                        string fechaBaja = vector[8];
                        string idUser = vector[9];
                        string host = vector[10];
                        string dni = vector[11];

                        sw.WriteLine(id + '+' + nombre + '+' + apellido + '+' + direccion + '+' + telefono + '+' + email + '+' + fechaAlta + '+' + fechaNacimiento + '+' + fechaBaja + '+' + idUser + '+' + host + '+' + dni + '+' + estado);
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
    }
}
