using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.Json;

namespace BlazorPokedex.Model.pokemon
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("types")]
        public List<Type> Types { get; set; }
        [JsonProperty("sprites")]
        public Sprite Sprite { get; set; }
        /* [JsonProperty("abilities")]
         public List<Abilities> Abilities { get; set; }*/
        [JsonProperty("base_experience")]
        public int Experience { get; set; }
        [JsonProperty("height")]
        public int Heigth { get; set; }
        [JsonProperty("weight")]
        public int Weight { get; set; }
    }
}
