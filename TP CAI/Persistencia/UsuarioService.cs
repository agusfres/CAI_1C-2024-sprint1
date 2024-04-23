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
            try
            {
                HttpResponseMessage response = WebHelper.Get(path);
                if (response.IsSuccessStatusCode)
                {
                    var contentStream = response.Content.ReadAsStringAsync().Result;
                    listaUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(contentStream);
                    return listaUsuarios;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
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
                throw new Exception("No tienes permiso para realizar esta acción");
            }
            if (response.StatusCode == HttpStatusCode.Conflict) // Valida error 409
            {
                throw new Exception("El nombre de usuario no puede contener el nombre o apellido");
            }
            if (response.StatusCode == HttpStatusCode.InternalServerError) // Valida error 500
            {
                throw new Exception("El usuario ya existe, intente con otro");
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
                throw new Exception(ex.Message);
            }
        }


        public static string Login(Login login)
        {
            var jsonRequest = JsonConvert.SerializeObject(login);

            HttpResponseMessage response = WebHelper.Post("/api/Usuario/Login", jsonRequest);

            if (response.StatusCode == HttpStatusCode.Conflict) // Valida error 409
            {
                throw new Exception("Usuario o contraseña incorrectos");
            }
            if (!response.IsSuccessStatusCode) // Valida errores que no sean de la familia del 200
            {
                throw new Exception("Verifique los datos ingresados");
            }

            var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
            string respuesta = reader.ReadToEnd();

            return respuesta;
        }


        public static string CambiarContraseña(string nombreUsuario, string contraseña, string contraseñaNueva)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("nombreUsuario", nombreUsuario);
            map.Add("contraseña", contraseña);
            map.Add("contraseñaNueva", contraseñaNueva);

            var jsonRequest = JsonConvert.SerializeObject(map);

            HttpResponseMessage response = WebHelper.Patch("Usuario/CambiarContraseña", jsonRequest);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Verifique los datos ingresados");
            }

            var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
            string respuesta = reader.ReadToEnd();

            return respuesta;
        }
    }
}