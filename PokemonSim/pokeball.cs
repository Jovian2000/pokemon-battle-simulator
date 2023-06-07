using System;

public class Pokeball
{
	private bool state; 
	private Pokemon pokemon;
	private bool health;
	private int id;
	public Pokeball(bool state, Pokemon pokemon, int id)
	{
		this.state = state;
		this.pokemon = pokemon;
		this.id = id;
		health = true;
	}

	public void setState(bool state)
	{
		this.state = state;
	}
	public bool getState()
	{
		return state;
	}

	public void setPokemon(Pokemon pokemon)
	{
		this.pokemon = pokemon;
	}

	public Pokemon getPokemon()
	{
		return pokemon;
	}

	public void setHealth(bool health)
	{
		this.health = health;
	}

	public bool getHealth() 
	{
		return health;
	}

	public void setId(int id)
	{
		this.id = id;
	}

	public int getId()
	{
		return id;
	}
	public void openPokeball()
	{
		state = true;
	}

	public void closePokeball()
	{
		state = false;
	}




}
