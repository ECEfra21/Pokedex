using Newtonsoft.Json;

namespace BlazorPokedex.Model.pokemon
{
    public class Stat
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}