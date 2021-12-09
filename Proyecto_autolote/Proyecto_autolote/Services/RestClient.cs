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

        public async Task<T> validacionUsuario<T>(string p_username, string p_pass)
        {
            HttpClient client = new HttpClient();
            string url = "https://apex.oracle.com/pls/apex/proyetoautolote/usuario/crud_usuario?id_usuario="
                        + p_username + "&password=" + p_pass;
            var response = await client.GetAsync(url);
            var jsonstring = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(jsonstring);
        }

    }
}
