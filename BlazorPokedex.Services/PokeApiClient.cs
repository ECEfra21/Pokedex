using BlazorPokedex.Model.peager;
using BlazorPokedex.Model.pokemon;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorPokedex.Services
{
    public class PokeApiClient : IPokeApiClient
    {
        public HttpClient _Client;
        public PokeApiClient(HttpClient client)
        {
            _Client = client;
        }
        public async Task<Pokemon> Get(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(await _Client.GetStringAsync($"pokemon/{name}"));
        }
        public async Task<ResultObjetc> GetAll(PaginationParameters parameters)
        {
            var res = JsonConvert.DeserializeObject<ResultObjetc>(await _Client.GetStringAsync($"pokemon?limit={parameters.PageSize}&offset={parameters.Offset}"));
            /*List<Pokemon> list = new List<Pokemon>();
            foreach (Pokemon item in res.Pokemons)
                            list.Add(await Get(item.Name));
                            return list;*/
            return res;
        }
    }
}
