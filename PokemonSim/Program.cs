namespace PokemonSim
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name trainer 1:");
            string nameInputChallenger = Console.ReadLine();
            Trainer challenger = new Trainer(nameInputChallenger);

            Console.WriteLine("Enter your name trainer 2:");
            string nameInputOpponent = Console.ReadLine();
            Trainer opponent = new Trainer(nameInputOpponent);

            Charmander charmander = new Charmander("Charmander", "Fire", "Water");
            Squirtle squirlte = new Squirtle("Squirtle", "Water", "Grass");
            Bulbasaur bulbasaur = new Bulbasaur("Bulbasaur", "Grass", "Fire");

            List<Pokeball> starterBeltChallenger = new List<Pokeball>();
            List<Pokeball> starterBeltOpponent = new List<Pokeball>();

            int i = 0;
            while (i != 6)
            {
                Pokeball charmanderPokeball = new Pokeball(true, charmander, i);
                starterBeltChallenger.Add(charmanderPokeball);
                starterBeltOpponent.Add(charmanderPokeball);
                i++;
                Pokeball squirtlePokeball = new Pokeball(true, squirlte, i);
                starterBeltChallenger.Add(squirtlePokeball);
                starterBeltOpponent.Add(squirtlePokeball);
                i++;
                Pokeball bulbasaurPokeball = new Pokeball(true, bulbasaur, i);
                starterBeltChallenger.Add(bulbasaurPokeball);
                starterBeltOpponent.Add(bulbasaurPokeball);
            }

            challenger.setBelt(starterBeltChallenger);
            opponent.setBelt(starterBeltOpponent);

            Battle battle = new Battle(challenger, opponent);
            Arena arena = new Arena(battle);
            arena.arenaBattle();
        }
    }
}