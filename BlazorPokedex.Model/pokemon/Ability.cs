using Newtonsoft.Json;

namespace BlazorPokedex.Model.pokemon
{
    public class Ability
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
