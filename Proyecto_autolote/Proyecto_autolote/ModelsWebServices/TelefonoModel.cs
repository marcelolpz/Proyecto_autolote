using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_autolote.ModelsWebServices
{
    
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ItemTelefono
    {
        public int id_telefono { get; set; }
        public string identidad { get; set; }
        public int telefono { get; set; }
    }

    public class LinkTelefono
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class TelefonoModel
    {
        public List<ItemTelefono> items { get; set; }
        public bool hasMore { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public List<LinkTelefono> links { get; set; }
    }


}
