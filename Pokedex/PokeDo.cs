using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace lab6.Pokemon
{
    public class Pokedex
    {
        private List<Pokemon> Pokemons;

        public Pokedex()
        {
            Pokemons = new List<Pokemon>();
        }

        public bool catchPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
            return true;
        }

        public bool releasePokemon(Pokemon pokemon)
        {
            return Pokemons.Remove(pokemon);
        }

        public List<Pokemon> MyPokedex()
        {
            return Pokemons;
        }
        public string IChooseYou(Pokemon firstPokemon, Pokemon secondPokemon)
        {
            if (firstPokemon == secondPokemon)
            {
                return "Empate superficaz";
            }
            else if (firstPokemon.Level > secondPokemon.Level)
            {
                return (firstPokemon.Name + " le gana a " + secondPokemon.Name);
            }
            else if (firstPokemon.Level < secondPokemon.Level)
            {
                return (firstPokemon.Name + " pierde contra " + secondPokemon.Name);
            }
            return "Ambos son del mismo nivel";
        }
    }
}
