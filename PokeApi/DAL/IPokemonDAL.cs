using PokeApi.Modelos;

namespace PokeApi.DAL
{
    public interface IPokemonDAL
    {
        public Task<List<Pokes>>GetPokes();
    }
}
