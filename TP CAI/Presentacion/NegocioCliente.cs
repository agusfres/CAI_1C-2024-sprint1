using Datos;
using Persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int host = 1;
            AltaCliente altaCliente = new AltaCliente(idVendedor, nombre, apellido, dni, direccion, telefono, email, fechaNacimiento, host);
            clienteService.AgregarCliente(altaCliente);
            Operacion operacion = new Operacion();
            Guid dniGuid = operacion.TransformarStringGuid(dni.ToString());
            Cliente clienteAuxiliar = BuscarCliente(dni);
            Cliente cliente = new Cliente(clienteAuxiliar.IdCliente, nombre, apellido, direccion, telefono, email, DateTime.Now, fechaNacimiento, null, dniGuid, host, dni);
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
            return clienteService.TraerClientesActivos();
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
    }
}
