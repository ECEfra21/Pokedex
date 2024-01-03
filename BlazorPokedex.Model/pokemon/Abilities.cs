using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlazorPokedex.Model.pokemon
{
    public class Abilities
    {
        [JsonProperty("is_hidden")]
        public bool Hidden { get; set; }
        [JsonProperty("ability")]
        public List<Ability> Ability { get; set; }
        [JsonProperty("slot")]
        public int Slot { get; set; }
    }
}
