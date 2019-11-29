using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace pokedex
{
    public partial class MainPage : ContentPage
    {
        internal ObservableCollection<Pokemon> pokemons = new ObservableCollection<Pokemon>
        {
            new Pokemon {
                Imagem = "abra.png",
                Nome="Abra",
                Tipo="Psi"
            },
            new Pokemon {
                Imagem = "alakazam.png",
                Nome="Alakazam",
                Tipo="Psi"
            },
            new Pokemon {
                Imagem = "blastoise.png",
                Nome="Blastoise",
                Tipo="Água"
            },
            new Pokemon {
                Imagem = "Bulbasaur.png",
                Nome="Bulbasaur",
                Tipo="Grama"
            }
        };

        public MainPage()
        {
            InitializeComponent();
            listPokemon.ItemsSource = pokemons;
        }

        private void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if(e == null)
            {
                return;
            }

            var detailPage = new DetailPage();
            detailPage.BindingContext = e.SelectedItem as Pokemon;
            //listPokemon.SelectedItem = null;
            Navigation.PushAsync(detailPage);
        }
    }
}
