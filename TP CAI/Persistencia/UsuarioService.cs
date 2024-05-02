using Newtonsoft.Json;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Net;
using System.Security.Policy;


namespace Persistencia
{
    public class UsuarioService
    {
        public List<Usuario> TraerUsuariosActivos(Guid idAdministrador)
        {
            string path = "/api/Usuario/TraerUsuariosActivos?id=" + idAdministrador;
            
            List<Usuario> listaUsuarios = new List<Usuario>();
            
            HttpResponseMessage response = WebHelper.Get(path);
                
            if (response.IsSuccessStatusCode)
            {
                var contentStream = response.Content.ReadAsStringAsync().Result;
                listaUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(contentStream);
            }

            return listaUsuarios;
        }



        public void AgregarUsuario(AltaUsuario altaUsuario)
        {
            string path = "/api/Usuario/AgregarUsuario";

            var jsonRequest = JsonConvert.SerializeObject(altaUsuario);

            HttpResponseMessage response = WebHelper.Post(path, jsonRequest);

            if (response.StatusCode == HttpStatusCode.NotFound) // Valida error 404
            {
                throw new Exception("Usuario no encontrado");
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


        public void BorrarUsuario(BajaUsuario bajaUsuario)
        {
            string path = "/api/Usuario/BajaUsuario";

            var jsonRequest = JsonConvert.SerializeObject(bajaUsuario);

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


        public static void Login(Login login)
        {
            string path = "/api/Usuario/Login";

            var jsonRequest = JsonConvert.SerializeObject(login);

            HttpResponseMessage response = WebHelper.Post(path, jsonRequest);

            if (response.StatusCode == HttpStatusCode.Conflict) // Valida error 409
            {
                throw new Exception("Usuario o contraseña incorrectos");
            }
            if (!response.IsSuccessStatusCode) // Valida errores que no sean de la familia del 200
            {
                throw new Exception("Verifique los datos ingresados");
            }
        }


        public static void CambiarContraseña(string nombreUsuario, string contraseña, string contraseñaNueva)
        {
            string path = "/api/Usuario/CambiarContraseña";

            Dictionary<string, string> map = new Dictionary<string, string>
            {
                { "nombreUsuario", nombreUsuario },
                { "contraseña", contraseña },
                { "contraseñaNueva", contraseñaNueva }
            };

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch(path, jsonRequest);

            if (response.StatusCode == HttpStatusCode.InternalServerError) // Valida error 500
            {
                throw new Exception("La contraseña no puede ser igual a la anterior");
            }
            if (response.StatusCode == HttpStatusCode.Conflict) // Valida error 409
            {
                throw new Exception("La contraseña es incorrecta");
            }
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados e intente nuevamente");
            }
        }
    }
}