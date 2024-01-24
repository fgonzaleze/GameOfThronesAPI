
using PokeApi.Modelos;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace PokeApi.DAL
{
    public class PokemonDAL : IPokemonDAL
    {
        private String url = "https://thronesapi.com/api/v2/Characters";
        public async Task<List<Pokes>> GetPokes()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            var responseBody = await response.Content.ReadAsStringAsync();


            var pokemonData = JsonSerializer.Deserialize<List<Pokes>>(responseBody.ToString());
            return pokemonData;
        }
    }
}
