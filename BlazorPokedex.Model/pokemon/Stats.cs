using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlazorPokedex.Model.pokemon
{
    public class Stats
    {
        [JsonProperty("base_stat")]
        public int BaseStat { get; set; }
        [JsonProperty("effort")]
        public int Effort { get; set; }
        [JsonProperty("stat")]
        public List<Stat> Stat { get; set; }
    }
}
