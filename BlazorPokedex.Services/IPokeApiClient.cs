using BlazorPokedex.Model.peager;
using BlazorPokedex.Model.pokemon;
using System.Threading.Tasks;

namespace BlazorPokedex.Services
{
    public interface IPokeApiClient
    {
        Task<ResultObjetc> GetAll(PaginationParameters parameters);
        Task<Pokemon> Get(string name);
    }
}
