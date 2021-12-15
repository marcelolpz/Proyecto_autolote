using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_autolote.ModelsWebServices
{
    public class ItemUsuario
    {
        public string id_usuario { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int id_tipo_usuario { get; set; }
        public int activo { get; set; }
        public string password { get; set; }
        public string correo { get; set; }
    }

    public class LinkUsuario
    {
        public string rel { get; set; }
        public string href { get; set; }
    }
    public class UsuarioModel
    {
        public List<ItemUsuario> items { get; set; }
        public bool hasMore { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public List<LinkUsuario> links { get; set; }
    }
}
