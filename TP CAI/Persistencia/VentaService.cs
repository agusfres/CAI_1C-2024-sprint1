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


namespace Persistencia
{
    public class VentaService
    {
        public void AgregarVenta(AltaVenta altaVenta)
        {
            string path = "/api/Venta/AgregarVenta";

            var jsonRequest = JsonConvert.SerializeObject(altaVenta);

            HttpResponseMessage response = WebHelper.Post(path, jsonRequest);

            if (response.StatusCode == HttpStatusCode.Forbidden) // Valida error 403
            {
                throw new Exception("No tienes permiso para realizar esta acción");
            }
            if (response.StatusCode == HttpStatusCode.Conflict) // Valida error 409
            {
                throw new Exception("La venta ya existe");
            }
            if (!response.IsSuccessStatusCode) // Valida errores que no sean de la familia del 200
            {
                throw new Exception("Hubo un error, intente nuevamente en unos segundos");
            }
        }


        public void Borrarventa(Bajaventa bajaVenta)
        {
            string path = "/api/Venta/DevolverVenta";

            var jsonRequest = JsonConvert.SerializeObject(bajaVenta);

            HttpResponseMessage response = WebHelper.DeleteWithBody(path, jsonRequest);

            if (response.StatusCode == HttpStatusCode.NotFound) // Valida error 404
            {
                throw new Exception("Usuario no encontrado");
            }
            if (response.StatusCode == HttpStatusCode.Forbidden) // Valida error 403
            {
                throw new Exception("No tienes permiso para realizar esta acción");
            }
            if (response.StatusCode == HttpStatusCode.Conflict) // Valida error 400
            {
                throw new Exception("Ingrese un Guid / id válido");
            }
            if (!response.IsSuccessStatusCode) // Valida errores que no sean de la familia del 200
            {
                throw new Exception("Hubo un error, intente nuevamente en unos segundos");
            }
        }


        public List<Venta> GetVentasByCliente(Guid idCliente)
        {
            string path = "/api/Venta/GetVentaByCliente?id=" + idCliente;

            List<Venta> listaVenta = new List<Venta>();

            HttpResponseMessage response = WebHelper.Get(path);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                listaVenta = JsonConvert.DeserializeObject<List<Venta>>(contentStream);
            }

            return listaVenta;
        }


        public Guid GetUltimaVentaCargada(Guid idCliente)
        {
            string path = "/api/Venta/GetVentaByCliente?id=" + idCliente;

            Guid idVenta = new Guid();

            HttpResponseMessage response = WebHelper.Get(path);

            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                List<Venta> listaVenta = JsonConvert.DeserializeObject<List<Venta>>(contentStream);
                idVenta = listaVenta[0].Id;
            }

            return idVenta;
        }
    }
}

