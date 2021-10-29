using Newtonsoft.Json;
using System;


namespace VerificaAPI.Entidades
{
    public class APIResponse
    {

        [JsonProperty("uf")]
        public string Uf { get; set; }
        [JsonProperty("state")] 
        public string State { get; set;}
        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        /***chuck
        [JsonProperty("value")]
        public string Value { get; set; }
       // [JsonProperty("advice")]
       // public string Advice { get; set; }
        ***/

        /*
        [JsonProperty("cep")]
        public String Cep { get; set; }
        [JsonProperty("logradouro")]
        public string  Logradouro { get; set; }
        */
        /*
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("advice")]
        public string Advice { get; set; }
        */

    }
}
