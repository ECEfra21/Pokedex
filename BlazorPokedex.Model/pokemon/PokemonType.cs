﻿using Newtonsoft.Json;

namespace BlazorPokedex.Model.pokemon
{
    public class PokemonType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
