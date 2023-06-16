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
	public void setPointsChallenger(int pointsChallenger)
	{
		this.pointsChallenger = pointsChallenger;
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
    public void checkResult(Trainer challenger, Trainer opponent)
    {
        Console.WriteLine("\nThis is the final result");
        Console.WriteLine("Total battles: " + battles); 
        Console.WriteLine("Total rounds: " + rounds);
        Console.WriteLine("Total rounds win " + challenger.getName() + ": " + pointsChallenger);
        Console.WriteLine("Total rounds win " + opponent.getName() + ": " + pointsOpponent);
        Console.WriteLine("Total rounds draw: " + drawPoints);
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