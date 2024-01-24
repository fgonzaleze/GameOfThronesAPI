using PokeApi.DAL;

namespace PokeApi
{
    public partial class MainPage : ContentPage
    {

        private readonly IPokemonDAL _pokemonDALService;
        public MainPage(IPokemonDAL service)
        {
            InitializeComponent();
            _pokemonDALService = service;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            cargando.IsVisible = true;

            var data = await _pokemonDALService.GetPokes();
            listViewPokemon.ItemsSource = data;

            cargando.IsVisible = false;

        }
    }

}
