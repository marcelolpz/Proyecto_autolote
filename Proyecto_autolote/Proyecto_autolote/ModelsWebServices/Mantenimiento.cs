using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_autolote.ModelsWebServices
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    
    public class ItemMantenimiento
    {
        public int id_mantenimiento { get; set; }
        public string placa { get; set; }
        public string descripcion_problema { get; set; }
        public string nombre_mecanico { get; set; }
        public int costo { get; set; }
        public DateTime fecha { get; set; }
    }

    public class LinkMantenimiento
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class MantenimientoModel
    {
        public List<ItemMantenimiento> items { get; set; }
        public bool hasMore { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public List<LinkMantenimiento> links { get; set; }
    }
}



