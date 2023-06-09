using System;

public class Arena
{
    private Battle battle;
	private int pointsChallenger;
	private int pointsOpponent;
	private int drawPoints;
	private int rounds;
    private int battles;
	public Arena(Battle battle)
	{
        this.battle = battle;
		pointsChallenger = 0;
		pointsOpponent = 0;
        drawPoints = 0;
		rounds = 0;
        battles = 0;
	}

    public Battle getBattle() 
    {
        return battle;
    }
	public int getPointsChallenger()
	{
		return pointsChallenger;
	}

    public int getPointsOpponent()
    {
        return pointsOpponent;
    }

	public int getRounds()
	{
		return rounds;
	}

    public int getBattles()
    {
        return battles;
    }

    public void setBattle(Battle battle)
    {
        this.battle = battle;
    }

	public void setPointsChallenger(int pointschallenger)
	{
		this.pointsChallenger = pointschallenger;
	}
	public void setPointsOpponent(int pointsOpponent)
	{
		this.pointsOpponent = pointsOpponent;
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
        Trainer challenger = new Trainer(nameInput1);

        Console.WriteLine("Enter your name trainer 2:");
        string nameInput2 = Console.ReadLine();
        Trainer opponent = new Trainer(nameInput2);

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

        challenger.setBelt(starterBelt1);
        opponent.setBelt(starterBelt2);
        List<Trainer> trainers = new List<Trainer>();
        trainers.Add(challenger);
        trainers.Add(opponent);
        return trainers;
    }
    public void checkResult(Trainer challenger, Trainer opponent)
    {
        Console.WriteLine("\nThis is the final result");
        Console.WriteLine("Total wins " + challenger.getName() + ": " + pointsChallenger);
        Console.WriteLine("Total wins " + opponent.getName() + ": " + pointsOpponent);
        Console.WriteLine("Total draws: " + drawPoints);
        Console.WriteLine("Total rounds: " + rounds);
        Console.WriteLine("Total battles: " + battles);
    }
	public void arenaBattle()
	{
        while (true)
        {
            string result = battle.pokemonBattle();
            if (result == "trainer 1")
            {
                pointsChallenger += 1;
            }
            else if (result == "trainer 2")
            {
                pointsOpponent += 1;
            } else
            {
                drawPoints += 1;
            }
            rounds += 1;
            battles += battle.getRoundsInBattle();
            Console.WriteLine("Another round? (y/n)");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "y")
            {
                checkResult(battle.getChallenger(), battle.getOpponent());
                break;
            } 
            else
            {
                battle.getChallenger().reviveAll();
                battle.getOpponent().reviveAll();
            } 
        }
    }
}
