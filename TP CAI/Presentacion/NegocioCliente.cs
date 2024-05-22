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
        private ClienteService clienteService = new ClienteService();
        private Guid idVendedor = Guid.Parse("70b37dc1-8fde-4840-be47-9ababd0ee7e5");
        string rutaLocal = @"C:\Users\USUARIOSISTEMA\ClientesLocales.txt";


        public void AgregarCliente(string nombre, string apellido, string direccion, string telefono, string email, DateTime fechaNacimiento,  int dni)
        {
            // Ponemos host como 1 ya que al usar 5 el web service da error 409 porqu solo permite un enum de 1, 2 o 3
            string host = "1";
            AltaCliente altaCliente = new AltaCliente(idVendedor, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, host);
            clienteService.AgregarCliente(altaCliente);
            Operacion operacion = new Operacion();
            Guid dniGuid = operacion.TransformarStringGuid(dni.ToString());
            Cliente clienteAuxiliar = BuscarCliente(dni);
            Cliente cliente = new Cliente(clienteAuxiliar.IdCliente, nombre, apellido, direccion, telefono, email, DateTime.Now, fechaNacimiento, null, dniGuid, host.ToString(), dni);
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
        public List<Cliente> TraerClientes()
        {
            List<Cliente> listaCliente = clienteService.TraerClientesActivos();
            return listaCliente;
        }
        private void AgregarClienteBaseLocal(Cliente cliente)
        {
            string docPath = rutaLocal;
            string nombreUsuarioSistema = Environment.UserName;
            string docPathAdaptado = docPath.Replace("USUARIOSISTEMA", nombreUsuarioSistema);

            StreamWriter writer = new StreamWriter(docPathAdaptado, true);

            try
            {
                writer.WriteLine(cliente.IdCliente + "+" + cliente.Nombre + "+" + cliente.Apellido + "+" + cliente.Direccion + "+" + cliente.Telefono + "+" + cliente.Email + "+" + cliente.FechaAlta + "+" + cliente.FechaNacimiento + "+null+" + cliente.IdUsuario + "+" + cliente.Dni + "+"  + cliente.Host);
            }
            catch
            {
                Console.WriteLine("error");
            }
            writer.Close();
        }

        public void ModificarCliente(Guid idUsuario, string direccion, string telefono, string email)
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
                         direccion = vector[3];
                         telefono = vector[4];
                         email = vector[5];
                        string fechaAlta = vector[6];
                        string fechaNacimiento = vector[7];
                        string fechaBaja = vector[8];
                        string idusuario = vector[9];
                        string dni = vector[10];
                        string host = vector[11];

                        sw.WriteLine(id + '+' + nombre + '+' + apellido + '+' + direccion + '+' + telefono + '+' + email + '+' + fechaAlta + '+' + fechaNacimiento + '+' + DateTime.Now + '+' + idUsuario + '+' + dni + '+'  + host);
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
