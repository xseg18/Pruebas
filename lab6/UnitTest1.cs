using lab6.Pokemon;
namespace lab6
{
    public class UnitTest1
    {
        [Fact]
        public void Pokedex_insertPokemon()
        {
            //Arr -> prepara la data
            Pokemon.Pokemon pikachu = new Pokemon.Pokemon("Pikachu", 50, 25, 10);
            //Act -> llama el método
            Pokemon.Pokedex pokedex = new Pokedex();
            var respuesta = pokedex.catchPokemon(pikachu);
            //Assser -> verifica
            Assert.Equal(respuesta, true);
        }

        [Fact]
        public void Pokedex_deletePokemon()
        {
            //Arr -> prepara la data
            Pokemon.Pokemon psyduck = new Pokemon.Pokemon("Psyduck", 10, 50, 15);
            //Act -> llama el método
            Pokemon.Pokedex pokedex = new Pokedex();
            pokedex.catchPokemon(psyduck);
            var respuesta = pokedex.releasePokemon(psyduck);
            //Assser -> verifica
            Assert.Equal(respuesta, true);
        }

        [Fact]
        public void Pokedex_fightPokemon()
        {
            //Arr -> prepara la data
            Pokemon.Pokemon psyduck = new Pokemon.Pokemon("Psyduck", 10, 50, 15);
            Pokemon.Pokemon pikachu = new Pokemon.Pokemon("Pikachu", 50, 25, 10);
            //Act -> llama el método
            Pokemon.Pokedex pokedex = new Pokedex();
            pokedex.catchPokemon(psyduck);
            pokedex.catchPokemon(pikachu);
            var respuesta = pokedex.IChooseYou(psyduck, pikachu);
            //Assser -> verifica
            Assert.Equal(respuesta, "Psyduck le gana a Pikachu");
        }
    }
}