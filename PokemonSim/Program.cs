namespace PokemonSim
{
    class Program
    {
        public static void Main(string[] args)
        {
            Charmander charmander = new Charmander("charmander", "fire", "water");
            while (true)
            {
                Console.WriteLine("Name your pokemon");
                string nameNew = Console.ReadLine();
                charmander.setName(nameNew);
    
                for (int i = 0; i < 10; i++)
                {
                    charmander.battleCry();
                }

                Console.WriteLine("Do you want to repeat? y/n");
                string answer = Console.ReadLine();
                if (answer.ToLower() != "y")
                {
                    break;
                }

            }

        }
    }
}