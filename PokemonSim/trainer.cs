using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
public class Trainer
{
	private string name;
	private List<Pokeball> belt;
	public Trainer(string name)
	{
		this.name = name;
		belt = new List<Pokeball>();
	}
	public void setName(string name)
	{
		this.name = name;
	}
	public void setBelt(List<Pokeball> belt)
	{
		int maxBelt = 6;
        errorHandling(maxBelt);

        if (belt.Count <= maxBelt) 
		{
			this.belt = belt;
		}
	}
	public string getName()
	{
		return name;
	}
	public List<Pokeball> getBelt()
	{
		return belt;
	}
	public void addPokeball (Pokeball pokeball)
	{
        int maxNum = 5;
		errorHandling(maxNum);

        if (belt.Count <= maxNum)
		{
			belt.Add(pokeball);
		} 
		else
		{
			Console.WriteLine("Six is the limit");
		}
	}
	//public void removePokeballs (int index)
	//{
	//	belt.RemoveAt(index);
	//}
	public void throwPokeball(Pokeball pokemon)
	{
		Console.WriteLine(name + ": Go " + pokemon.getPokemon() + "!!");
		pokemon.openPokeball();
    }
	public void returnPokemon(Pokeball pokemon)
	{
        Console.WriteLine(name + ": Get Back " + pokemon.getPokemon());
		pokemon.closePokeball();
    }
	public Pokeball pickRandomPokeball()
	{
		if (!checkBelt())
		{
			return null;
		}	
		List<Pokeball> pokeballsAvailable = new List<Pokeball>();
		foreach (Pokeball pokeball in belt)
		{
			if (pokeball.getPokemon().getHealth())
			{
				pokeballsAvailable.Add(pokeball);
			} 
		}
		Random rnd = new Random();
		int num = rnd.Next(0, pokeballsAvailable.Count);
		Pokeball randomPokeball = pokeballsAvailable[num];
		return randomPokeball;
	}
	public bool checkBelt() 
	{
		int pokemonAvailable = 0;
		foreach (Pokeball pokeball in belt)
		{
			if (pokeball.getPokemon().getHealth())
			{
				pokemonAvailable += 1;
			}
		}
		if (pokemonAvailable > 0)
		{
			return true;
		} 
		else
		{
			return false;
		}
	}
	public void reviveAll()
	{
		foreach (Pokeball pokeball in belt)
		{
			pokeball.getPokemon().setHealth(true);
		}
	}
	public void printPokemons()
	{
		foreach (Pokeball pokeball in belt)
		{
			Console.WriteLine(pokeball.getPokemon().getName());
		}
	}
	public void setStandardBelt()
	{
		try
		{
			int i = 1;
			while (i < 6)
			{
				Pokeball charmanderPokeball = new Pokeball(true, new Charmander("Charmander", i));
				addPokeball(charmanderPokeball);
				i++;
				Pokeball squirtlePokeball = new Pokeball(true, new Squirtle("Squirtle", i));
				addPokeball(squirtlePokeball);
				i++;
				Pokeball bulbasaurPokeball = new Pokeball(true, new Bulbasaur("Bulbasaur", i));
				addPokeball(bulbasaurPokeball);
				i++;
			}
		}
         catch (ArgumentOutOfRangeException e)
		{
			Console.WriteLine(e.ToString());
		}
    }
	private void errorHandling(int num)
	{
		int maxNum = num;
		int minNum = 0;

        if (belt.Count > maxNum)
        {
            throw new ArgumentOutOfRangeException("The belt can only contain six pokeballs or less.");
        }
        else if (belt.Count < minNum)
        {
            throw new ArgumentOutOfRangeException("The belt size cannot be lower than 0");
        }
    }
//	public void createBelt(Pokeball pokeball)
//	{
//		
//	}
}