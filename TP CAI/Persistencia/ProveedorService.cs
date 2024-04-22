using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ProveedorService
    {
        public List<Proveedor> TraerProveedores(Guid idAdministrador)
        {
            string path = "/api/Proveedor/TraerProveedores" + idAdministrador;
            List<Proveedor> listaProveedores = new List<Proveedor>();
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    listaProveedores = JsonConvert.DeserializeObject<List<Proveedor>>(contentStream);
                    return listaProveedores;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return listaProveedores;
        }

        public void ModificarProveedor(Guid id, Guid idUsuario, string nombre, string apellido, string email,string cuit)
        {
            string path = "/api/Proveedor/ModificarProveedor";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", id.ToString());
            map.Add("id", idUsuario.ToString());
            map.Add("nombre", nombre);
            map.Add("apellido", apellido);
            map.Add("email", email);
            map.Add("cuit", cuit);

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void AgregarProveedor(AltaProveedor altaproveedor)
        {
            string path = "/api/Proveedor/AgregarProveedor";

            var jsonRequest = JsonConvert.SerializeObject(altaproveedor);

            try
            {
                HttpResponseMessage response = WebHelper.Post(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        public void BajaProveedor(BajaProveedor bajaProveedor)
        {
            string path = "/api/Proveedor/BajaProveedor";

            var jsonRequest = JsonConvert.SerializeObject(bajaProveedor);

            try
            {
                HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    throw new Exception($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception: {ex.Message}");
            }
        }

        public void ReactivarProveedor(Guid id, Guid idUsuario)
        {
            string path = "/api/Proveedor/ReactivarProveedor";
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("id", id.ToString());
            map.Add("id", idUsuario.ToString());
     

            var jsonRequest = JsonConvert.SerializeObject(map);

            try
            {
                HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);
                if (response.IsSuccessStatusCode)
                {
                    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
                    string respuesta = reader.ReadToEnd();
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
