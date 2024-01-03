using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlazorPokedex.Model.pokemon
{
    public class ResultObjetc
    {
        [JsonProperty("results")]
        public List<Pokemon> Pokemons { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}
