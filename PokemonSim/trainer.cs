using System;
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
		this.belt = belt;
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
		if (belt.Count <= 6)
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
		List<Pokeball> pokeballs = new List<Pokeball>();
		foreach (Pokeball pokemon in belt)
		{
			if (pokemon.getHealth())
			{
				pokeballs.Add(pokemon);
			} 
		}
		Random rnd = new Random();
		int num = rnd.Next(0, pokeballs.Count);
		Pokeball pokeball = pokeballs[num];
		return pokeball;
	}

	public bool checkBelt() 
	{
		int pokemon = 0;
		foreach (Pokeball p in belt)
		{
			if (p.getHealth())
			{
				pokemon += 1;
			}
		}
		if (pokemon > 0)
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
			pokeball.setHealth(true);
		}
	}
	public void printPokemons()
	{
		foreach (Pokeball pokeball in belt)
		{
			Console.WriteLine(pokeball.getPokemon().getName());
		}
	}
}
