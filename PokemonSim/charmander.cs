using System;
class Charmander
{
	public string name;
	public string strength;
	public string weakness;

	public Charmander(string name, string strength, string weakness)
	{
		this.name = name;
		this.strength = strength;
		this.weakness = weakness;
	}

	public string getName()
	{
		return name;
	}

    public void setName(string newName)
    {
        name = newName;
    }

	public void battleCry()
	{
		Console.WriteLine(name + " uses battle cry");
	}
}