using Datos;
using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ProveedorService
    {
        public void AgregarProveedor(AltaProveedor altaProveedor)
        {
            string path = "/api/Proveedor/AgregarProveedor";

            var jsonRequest = JsonConvert.SerializeObject(altaProveedor);

            HttpResponseMessage response = WebHelper.Post(path, jsonRequest);

            if (response.StatusCode == HttpStatusCode.Forbidden) // Valida error 403
            {
                throw new Exception("No tienes permiso para realizar esta acción");
            }
            if (response.StatusCode == HttpStatusCode.Conflict) // Valida error 409
            {
                throw new Exception("El proveedor ya existe");
            }
            if (!response.IsSuccessStatusCode) // Valida errores que no sean de la familia del 200
            {
                throw new Exception("Hubo un error, intente nuevamente en unos segundos");
            }
        }


        public void BajaProveedor(Guid id, Guid idAdministrador)
        {
            string path = "/api/Proveedor/BajaProveedor";

            Dictionary<string, Guid> map = new Dictionary<string, Guid>
            {
                { "id", id },
                { "idUsuario", idAdministrador }
            };

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);

            if (response.StatusCode == HttpStatusCode.NotFound) // Valida error 404
            {
                throw new Exception("Proveedor no encontrado");
            }
            if (!response.IsSuccessStatusCode) // Valida errores que no sean de la familia del 200
            {
                throw new Exception("Hubo un error, intente nuevamente en unos segundos");
            }
        }
    

        public List<Proveedor> TraerProveedoresActivos()
        {
            string path = "/api/Proveedor/TraerProveedores";

            List<Proveedor> listaProveedores = new List<Proveedor>();

            HttpResponseMessage response = WebHelper.Get(path);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                listaProveedores = JsonConvert.DeserializeObject<List<Proveedor>>(contentStream);
            }

            return listaProveedores;
        }
    }
}
