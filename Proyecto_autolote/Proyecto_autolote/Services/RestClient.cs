using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_autolote.Services
{
    public class RestClient
    {
        private string weblinkUrl;

        public async Task<T> validacionUsuario<T>(string p_username, string p_password)
        {
            HttpClient client = new HttpClient();
            string url = "https://apex.oracle.com/pls/apex/proyetoautolote/InicioSesion/USER?p_username="
                        + p_username + "&p_password=" + p_password;
            var response = await client.GetAsync(url);
            var jsonstring = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);
        }

        public async Task<T> ListaUsuarios<T>()
        {
            HttpClient client = new HttpClient();
            string url = "https://apex.oracle.com/pls/apex/proyetoautolote/usuario/crud_usuario";
            var response = await client.GetAsync(url);
            var jsonstring = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);
        }

        public async Task<T> ListaAutos<T>()
        {
            HttpClient client = new HttpClient();
            string url = "https://apex.oracle.com/pls/apex/proyetoautolote/auto/crud_auto";
            var response = await client.GetAsync(url);
            var jsonstring = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);
        }

    }
}
