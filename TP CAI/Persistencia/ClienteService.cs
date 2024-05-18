using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;

namespace Persistencia
{
    public class ClienteService
    {
        public List<Cliente> TraerClientesActivos()
        {
            string path = "/api/Cliente/GetClientes";

            List<Cliente> listaClientes = new List<Cliente>();

            HttpResponseMessage response = WebHelper.Get(path);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                listaClientes = JsonConvert.DeserializeObject<List<Cliente>>(contentStream);
            }

            return listaClientes;
        }
        public Cliente TraerCliente( Guid idVendedor)
        {
            string path = "/api/Cliente/GetClientes?id=" + idVendedor;

            Cliente cliente = new Cliente();

            HttpResponseMessage response = WebHelper.Get(path);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                cliente = JsonConvert.DeserializeObject<Cliente>(contentStream);
            }

            return cliente;
        }



        public void AgregarCliente(AltaCliente altaCliente)
        {
            string path = "/api/Cliente/AgregarCliente";

            var jsonRequest = JsonConvert.SerializeObject(altaCliente);

            HttpResponseMessage response = WebHelper.Post(path, jsonRequest);

            if (response.StatusCode == HttpStatusCode.NotFound) // Valida error 404
            {
                throw new Exception("Cliente no encontrado");
            }
            if (response.StatusCode == HttpStatusCode.Forbidden) // Valida error 403
            {
                throw new Exception("No tienes permiso para realizar esta acción");
            }
            if (response.StatusCode == HttpStatusCode.Conflict) // Valida error 409
            {
                throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase} - {response.Content}");
            }
            if (response.StatusCode == HttpStatusCode.InternalServerError) // Valida error 500
            {
                throw new Exception(response.Content.ToString());
            }
            if (!response.IsSuccessStatusCode) // Valida errores que no sean de la familia del 200
            {
                throw new Exception("Hubo un error, intente nuevamente en unos segundos");
            }
        }

        public static void ModificarCliente(string idUsuario, string direccion, string telefono, string email  )
        {
            string path = "/api/Cliente/PatchCliente";

            Dictionary<string, string> map = new Dictionary<string, string>
            {
                { "id", idUsuario },
                { "direccion", direccion },
                { "telefono", telefono },
                { "email", email }
            };

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);

            if (response.StatusCode == HttpStatusCode.InternalServerError) // Valida error 500
            {
                throw new Exception("Los datos no pueden ser iguales a los anteriores");
            }
            if (response.StatusCode == HttpStatusCode.Conflict) // Valida error 409
            {
                throw new Exception("El cliente es incorrecto");
            }
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados e intente nuevamente");
            }
        }



    }
}
