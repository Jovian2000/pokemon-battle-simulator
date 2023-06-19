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

            Battle battle = new Battle(challenger, opponent);
            Arena arena = new Arena(battle);
            arena.arenaBattle();
        }
    }
}