using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_autolote.ModelsWebServices
{
    
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ItemCliente
    {
        public string identidad { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
    }

    public class LinkCliente
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class ClienteModel
    {
        public List<ItemCliente> items { get; set; }
        public bool hasMore { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public List<LinkCliente> links { get; set; }
    }

}
