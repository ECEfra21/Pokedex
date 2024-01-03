using Newtonsoft.Json;

namespace BlazorPokedex.Model.pokemon
{
    public class Type
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }
        [JsonProperty("type")]
        public PokemonType PokemonType { get; set; }
    }
}
