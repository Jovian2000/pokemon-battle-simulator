namespace PokemonSim
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Charmander charmander = new Charmander("charmander", "fire", "water");
            //while (true)
            //{
            //    Console.WriteLine("Name your pokemon");
            //    string nameNew = Console.ReadLine();
            //    charmander.setName(nameNew);

            //    for (int i = 0; i < 10; i++)
            //    {
            //        charmander.battleCry();
            //    }

            //    Console.WriteLine("Do you want to repeat? y/n");
            //    string answer = Console.ReadLine();
            //    if (answer.ToLower() != "y")
            //    {
            //        break;
            //    }
            //}


            Console.WriteLine("Enter your name trainer 1:");
            string nameInput1 = Console.ReadLine();
            Trainer trainer1 = new Trainer(nameInput1);

            Console.WriteLine("Enter your name trainer 2:");
            string nameInput2 = Console.ReadLine();
            Trainer trainer2 = new Trainer(nameInput2);

            Charmander charmender = new Charmander("charmender", "fire", "water");
            Pokeball newPokeball = new Pokeball(true, charmender);

            List<Pokeball> starterBelt = new List<Pokeball>();

            for (int i = 0; i < 6; i++) 
            {
                starterBelt.Add(newPokeball);
            }

            trainer1.setBelt(starterBelt);
            trainer2.setBelt(starterBelt);

            while (true)
            {
                foreach (Pokeball pokeball in starterBelt)
                {
                    Console.WriteLine(trainer1.getName() + ": ");
                    trainer1.throwPokeball(pokeball);
                    pokeball.pokemon.battleCry();
                    trainer1.returnPokemon(pokeball);

                    Console.WriteLine(trainer2.getName() + ": ");
                    trainer2.throwPokeball(pokeball);
                    pokeball.pokemon.battleCry();
                    trainer2.returnPokemon(pokeball);

                    Console.WriteLine("Do you want to play again? (y/n)");
                    string answer = Console.ReadLine();
                    if (answer.ToLower() != "y")
                    {
                        break;
                    }
                }
            }
        }
    }
}