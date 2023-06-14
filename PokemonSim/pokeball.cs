using System;
public class Pokeball
{
	private bool state; 
	private Pokemon pokemon;
	public Pokeball(bool state, Pokemon pokemon)
	{
		this.state = state;
		this.pokemon = pokemon;
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
	public void openPokeball()
	{
		state = true;
	}
	public void closePokeball()
	{
		state = false;
	}
}