using System;

class Pokeball
{
	public bool state; 
	public Charmander pokemon;
	public Pokeball(bool state, Charmander pokemon)
	{
		this.state = state;
		this.pokemon = pokemon;
	}

	public void setPokemon(Charmander pokemon)
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
