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
		int maxBelt = 6;
		if (belt.Count <= maxBelt) 
		{
			this.belt = belt;
		} else
		{
			Console.WriteLine("Six is the limit");
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
        int maxBelt = 6;
        if (belt.Count <= maxBelt)
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
        List<Pokeball> trainerBelt = new List<Pokeball>();
        int i = 0;
        while (i != 6)
        {
            Pokeball charmanderPokeball = new Pokeball(true, new Charmander("Charmander", i));
            trainerBelt.Add(charmanderPokeball);
            i++;
            Pokeball squirtlePokeball = new Pokeball(true, new Squirtle("Squirtle", i));
            trainerBelt.Add(squirtlePokeball);
            i++;
            Pokeball bulbasaurPokeball = new Pokeball(true, new Bulbasaur("Bulbasaur", i));
            trainerBelt.Add(bulbasaurPokeball);
			i++;
        }
		setBelt(trainerBelt);
    }
//	public void createBelt(Pokeball pokeball)
//	{
//		
//	}
}