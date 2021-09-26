using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AccesoDatos.Util
{
    public class DtoRestaurante
    {
        [JsonProperty("dt1")]
        public string Nombre { get; set; }
        [JsonProperty("dt2")]
        public string Ciudad { get; set; }
        [JsonProperty("dt3")]
        public string Telefono { get; set; }
        [JsonProperty("ndt1")]
        public decimal IdRestaurante { get; set; }
        [JsonProperty("ndt2")]
        public decimal IdCiudad { get; set; }
        [JsonProperty("ndt3")]
        public decimal NumeroAforo { get; set; }
    }

}
