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

            challenger.setStandardBelt();
            opponent.setStandardBelt();
            challenger.printPokemons();
            opponent.printPokemons();
            Console.WriteLine(challenger.getBelt().Count);
            Console.WriteLine(opponent.getBelt().Count);

            Battle battle = new Battle(challenger, opponent);
            Arena arena = new Arena(battle);
            arena.arenaBattle();
        }
    }
}