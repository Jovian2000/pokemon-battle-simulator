using System;

public class Battle
{
	private Trainer trainer1;
	private Trainer trainer2;
	private int roundsInBattle;
	public Battle(Trainer trainer1, Trainer trainer2)
	{
		this.trainer1 = trainer1;
		this.trainer2 = trainer2;
		roundsInBattle = 0;
	}
	public Trainer getTrainer1()
	{
		return trainer1;
	}

	public Trainer getTrainer2()
	{
		return trainer2;
	}
	public int getRoundsInBattle() 
	{
		return roundsInBattle;
	}
	public void setTrainer1(Trainer trainer1)
	{
		this.trainer1 = trainer1;
	}
	public void setTrainer2(Trainer trainer2)
	{
		this.trainer2 = trainer2;
	}
	public void setRoundsinBattle(int roundsInBattle) 
	{
		this.roundsInBattle = roundsInBattle;
	}
	public string pokemonBattle()
	{
		int numBattle = 0;
		int pointTrainer1 = 0;
		int pointTrainer2 = 0;
		int drawPoints = 0;
        string winner = "none";
        Pokeball trainer1Pokeball = trainer1.pickRandomPokeball();
        Pokeball trainer2Pokeball = trainer2.pickRandomPokeball();

        while (true)
		{
			if (!trainer1.checkBelt() || !trainer2.checkBelt())
			{
				break;
			}
 
			if (winner == "trainer 1")
			{
                trainer2Pokeball = trainer2.pickRandomPokeball();
                trainer2.throwPokeball(trainer2Pokeball);
            } 
			else if (winner == "trainer 2")
			{
                trainer1Pokeball = trainer1.pickRandomPokeball();
                trainer1.throwPokeball(trainer1Pokeball);
            }
            else
			{
                trainer2Pokeball = trainer2.pickRandomPokeball();
                trainer1Pokeball = trainer1.pickRandomPokeball();
                trainer1.throwPokeball(trainer1Pokeball);
                trainer2.throwPokeball(trainer2Pokeball);
            }
			Console.WriteLine(trainer1.getName() + " picked " + trainer1Pokeball.getPokemon().getName());
			Console.WriteLine(trainer2.getName() + " picked " + trainer2Pokeball.getPokemon().getName());
			if (trainer1Pokeball.getPokemon().getStrength() == trainer2Pokeball.getPokemon().getWeakness())
			{
				trainer2Pokeball.setHealth(false);
				trainer2.returnPokemon(trainer2Pokeball);
				Console.WriteLine(trainer1.getName() + " wins!\n");
				winner = "trainer 1";
				pointTrainer1 += 1;
			}
			else if (trainer2Pokeball.getPokemon().getStrength() == trainer1Pokeball.getPokemon().getWeakness())
			{
				trainer1Pokeball.setHealth(false);
                trainer1.returnPokemon(trainer1Pokeball);
				Console.WriteLine(trainer2.getName() + " wins!\n");
                winner = "trainer 2";
                pointTrainer2 += 1;
			}
			else
			{
				if (winner == "trainer 1")
				{
                    trainer1Pokeball.setHealth(false);
                    trainer1.returnPokemon(trainer1Pokeball);
					winner = "trainer 2";
                } 
				else if (winner == "trainer 2")
				{
                    trainer2Pokeball.setHealth(false);
                    trainer2.returnPokemon(trainer2Pokeball);
					winner = "trainer 1";
				} 
				else
				{
                    trainer2Pokeball.setHealth(false);
                    trainer1Pokeball.setHealth(false);
                    trainer1.returnPokemon(trainer1Pokeball);
                    trainer2.returnPokemon(trainer2Pokeball);
                }
                Console.WriteLine("Its a draw!\n");
				drawPoints += 1;
			}
            numBattle += 1;
			roundsInBattle += numBattle;
        }
		Console.WriteLine("End");
		Console.WriteLine("Battles fought: " + numBattle);
		Console.WriteLine(trainer1.getName() + ": " + pointTrainer1);
		Console.WriteLine(trainer2.getName() + ": " + pointTrainer2);
		Console.WriteLine("Draws: " + drawPoints);
		if (pointTrainer1 > pointTrainer2)
		{
			Console.WriteLine(trainer1.getName() + " wins the battle!");
			return "trainer 1";
		} 
		else if (pointTrainer2 > pointTrainer1) 
		{
			Console.WriteLine(trainer2.getName() + " wins the battle!");
            return "trainer 2";
        }
        else
		{
			Console.WriteLine("You guys drawed");
			return "draw";
		}
	} 
}
