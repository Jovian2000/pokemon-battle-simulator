using System;

public class Pokeball
{
	public bool state; 
	public Pokemon pokemon;
	public Pokeball(bool state, Pokemon pokemon)
	{
		this.state = state;
		this.pokemon = pokemon;
	}

	public void setPokemon(Pokemon pokemon)
	{
		this.pokemon = pokemon;
	}

	public string getPokemon()
	{
		return pokemon.name;
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
