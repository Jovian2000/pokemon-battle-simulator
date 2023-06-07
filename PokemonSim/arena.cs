using System;

public class Arena
{
	private int pointsTrainer1;
	private int pointsTrainer2;
	private int rounds;
    private int battles;
	public Arena()
	{
		pointsTrainer1 = 0;
		pointsTrainer2 = 0;
		rounds = 0;
        battles = 0;
	}

	public int getPointsTrainer1()
	{
		return pointsTrainer1;
	}

    public int getPointsTrainer2()
    {
        return pointsTrainer2;
    }

	public int getRounds()
	{
		return rounds;
	}

    public int getBattles()
    {
        return battles;
    }

	public void setPointsTrainer1(int pointsTrainer1)
	{
		this.pointsTrainer1 = pointsTrainer1;
	}
	public void setPointsTrainer2(int pointsTrainer2)
	{
		this.pointsTrainer2 = pointsTrainer2;
	}

	public void setRounds(int rounds)
	{
		this.rounds = rounds;
	}

    public void setBattles(int battles)
    {
        this.battles = battles;
    }

    public List<Trainer> setStandardTrainers()
    {
        Console.WriteLine("Enter your name trainer 1:");
        string nameInput1 = Console.ReadLine();
        Trainer trainer1 = new Trainer(nameInput1);

        Console.WriteLine("Enter your name trainer 2:");
        string nameInput2 = Console.ReadLine();
        Trainer trainer2 = new Trainer(nameInput2);

        Charmander charmander = new Charmander("Charmander", "Fire", "Water");
        Squirtle squirlte = new Squirtle("Squirtle", "Water", "Grass");
        Bulbasaur bulbasaur = new Bulbasaur("Bulbasaur", "Grass", "Fire");


        List<Pokeball> starterBelt1 = new List<Pokeball>();
        List<Pokeball> starterBelt2 = new List<Pokeball>();

        int i = 0;
        while (i != 6)
        {
            Pokeball charmanderPokeball = new Pokeball(true, charmander, i);
            starterBelt1.Add(charmanderPokeball);
            starterBelt2.Add(charmanderPokeball);
            i++;
            Pokeball squirtlePokeball = new Pokeball(true, squirlte, i);
            starterBelt1.Add(squirtlePokeball);
            starterBelt2.Add(squirtlePokeball);
            i++;
            Pokeball bulbasaurPokeball = new Pokeball(true, bulbasaur, i);
            starterBelt1.Add(bulbasaurPokeball);
            starterBelt2.Add(bulbasaurPokeball);
        }

        trainer1.setBelt(starterBelt1);
        trainer2.setBelt(starterBelt2);
        List<Trainer> trainers = new List<Trainer>();
        trainers.Add(trainer1);
        trainers.Add(trainer2);
        return trainers;
    }
    public void checkResult(Trainer trainer1, Trainer trainer2)
    {
        Console.WriteLine("\nThis is the final result");
        Console.WriteLine("Total wins " + trainer1.getName() + ": " + pointsTrainer1);
        Console.WriteLine("Total wins " + trainer2.getName() + ": " + pointsTrainer2);
        Console.WriteLine("Total rounds: " + rounds);
        Console.WriteLine("Total battles: " + battles);
    }
	public void arenaBattle()
	{
        List<Trainer> trainers = setStandardTrainers();
        Trainer trainer1 = trainers[0];
        Trainer trainer2 = trainers[1];
        Battle battle = new Battle(trainer1, trainer2);
        while (true)
        {
            string result = battle.pokemonBattle();
            if (result == "trainer 1")
            {
                pointsTrainer1 += 1;
            }
            else if (result == "trainer 2")
            {
                pointsTrainer2 += 1;
            }
            rounds += 1;
            battles += battle.getRoundsInBattle();
            Console.WriteLine("Another round? (y/n)");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "y")
            {
                checkResult(trainer1, trainer2);
                break;
            } 
            else
            {
                battle.getTrainer1().reviveAll();
                battle.getTrainer2().reviveAll();
            } 
        }
    }
}
