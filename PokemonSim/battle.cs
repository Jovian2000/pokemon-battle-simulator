using System;
public class Battle
{
	private Trainer challenger;
	private Trainer opponent;
	private int roundsInBattle;
	public Battle(Trainer challenger, Trainer opponent)
	{
		this.challenger = challenger;
		this.opponent = opponent;
		roundsInBattle = 0;
	}
	public Trainer getChallenger()
	{
		return challenger;
	}
	public Trainer getOpponent()
	{
		return opponent;
	}
	public int getRoundsInBattle() 
	{
		return roundsInBattle;
	}
	public void setChallenger(Trainer challenger)
	{
		this.challenger = challenger;
	}
	public void setOpponent(Trainer opponent)
	{
		this.opponent = opponent;
	}
	public void setRoundsinBattle(int roundsInBattle) 
	{
		this.roundsInBattle = roundsInBattle;
	}
	public string pokemonBattle()
	{
		int numBattle = 0;
		int pointChallenger = 0;
		int pointOpponent = 0;
		int drawPoints = 0;
        string winner = "none";
        Pokeball challengerPokeball = challenger.pickRandomPokeball();
        Pokeball opponentPokeball = opponent.pickRandomPokeball();

        while (true)
		{
            if (!challenger.checkBelt() || !opponent.checkBelt())
			{
				break;
			}
			
			if (winner == "trainer 1")
			{
                opponentPokeball = opponent.pickRandomPokeball();
                opponent.throwPokeball(opponentPokeball);
            } 
			else if (winner == "trainer 2")
			{
                challengerPokeball = challenger.pickRandomPokeball();
                challenger.throwPokeball(challengerPokeball);
            }	
            else
			{
                opponentPokeball = opponent.pickRandomPokeball();
                challengerPokeball = challenger.pickRandomPokeball();
                challenger.throwPokeball(challengerPokeball);
                opponent.throwPokeball(opponentPokeball);
            }

            Pokemon challengerPokemon = challengerPokeball.getPokemon();
            Pokemon opponentPokemon = opponentPokeball.getPokemon();

            Console.WriteLine(challenger.getName() + " picked " + challengerPokemon.getName());
			Console.WriteLine(opponent.getName() + " picked " + opponentPokemon.getName());

            if (challengerPokemon.getStrength() == opponentPokemon.getWeakness())
			{
				opponentPokemon.setHealth(false);
				opponent.returnPokemon(opponentPokeball);
				Console.WriteLine(challenger.getName() + " wins!\n");
				winner = "trainer 1";
				pointChallenger += 1;
			}
			else if (opponentPokemon.getStrength() == challengerPokemon.getWeakness())
			{
				challengerPokemon.setHealth(false);
                challenger.returnPokemon(challengerPokeball);
				Console.WriteLine(opponent.getName() + " wins!\n");
                winner = "trainer 2";
                pointOpponent += 1;
			}
			else
			{
				if (winner == "trainer 1")
				{
                    challengerPokemon.setHealth(false);
                    challenger.returnPokemon(challengerPokeball);
					winner = "trainer 2";
                } 
				else if (winner == "trainer 2")
				{
                    opponentPokemon.setHealth(false);
                    opponent.returnPokemon(opponentPokeball);
					winner = "trainer 1";
				} 
				else
				{
                    opponentPokemon.setHealth(false);
                    challengerPokemon.setHealth(false);
                    challenger.returnPokemon(challengerPokeball);
                    opponent.returnPokemon(opponentPokeball);
                }
                Console.WriteLine("Its a draw!\n");
				drawPoints += 1;
			}
            numBattle += 1;
        }

		Console.WriteLine("End");
		Console.WriteLine("Battles fought: " + numBattle);
		Console.WriteLine("points " + challenger.getName() + ": " + pointChallenger);
		Console.WriteLine("points " + opponent.getName() + ": " + pointOpponent);
		Console.WriteLine("Draws: " + drawPoints);
        roundsInBattle = numBattle;

        if (pointChallenger > pointOpponent)
		{
			Console.WriteLine(challenger.getName() + " wins the battle!");
			return "trainer 1";
		} 
		else if (pointOpponent > pointChallenger) 
		{
			Console.WriteLine(opponent.getName() + " wins the battle!");
            return "trainer 2";
        }
        else
		{
			Console.WriteLine("You guys drawed");
			return "draw";
		}
	} 
}