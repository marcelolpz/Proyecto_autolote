using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_autolote.ModelsWebServices
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class ItemDetalle
    {
        public int id_detalle { get; set; }
        public int id_factura { get; set; }
        public string placa { get; set; }
        public int id_tipo_pago { get; set; }
        public string traspaso { get; set; }
        public object mime_char { get; set; }
        public object filename { get; set; }
        public object char_set { get; set; }
    }

    public class LinkDetalle
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    public class DetalleModel
    {
        public List<ItemDetalle> items { get; set; }
        public bool hasMore { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int count { get; set; }
        public List<LinkDetalle> links { get; set; }
    }

}
