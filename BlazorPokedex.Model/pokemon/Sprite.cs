using Newtonsoft.Json;

namespace BlazorPokedex.Model.pokemon
{
    public class Sprite
    {
        [JsonProperty("front_default")]
        public string Front { get; set; }
        [JsonProperty("back_default")]
        public string Back { get; set; }
        [JsonProperty("back_shiny")]
        public string BackShiny { get; set; }
        [JsonProperty("front_shiny")]
        public string FrontShiny { get; set; }
    }
}
