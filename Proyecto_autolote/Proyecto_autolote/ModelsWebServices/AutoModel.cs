using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_autolote.ModelsWebServices
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ItemAuto
    {
        public string placa { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public int precio { get; set; }
        public int? foto { get; set; }
        public string mime_char { get; set; }
        public string file_name { get; set; }
        public object char_set { get; set; }
        public string tipo_estado { get; set; }
    }

    public class LinkAuto
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class AutoModel
    {
        public List<ItemAuto> items { get; set; }
        public bool hasMore { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public List<LinkAuto> links { get; set; }
    }
}
