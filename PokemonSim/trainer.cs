using System;
using System.Security.Cryptography.X509Certificates;

public class Trainer
{
	public string name;
	public List<Pokeball> belt;

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
		} else
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
		Console.WriteLine("Go " + pokemon.getPokemon() + "!!");
		pokemon.openPokeball();
    }

	public void returnPokemon(Pokeball pokemon)
	{
        Console.WriteLine("Get Back " + pokemon.getPokemon());
		pokemon.closePokeball();
    }
}
