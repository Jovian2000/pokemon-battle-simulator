using System;
using System.Xml.Linq;

public abstract class Pokemon
{
    public string name;
    public string strength;
    public string weakness;
    public Pokemon(string name, string strength, string weakness)
	{
        this.name = name;
        this.strength = strength;
        this.weakness = weakness;
    }
    public abstract void battleCry();

    public string getName()
    {
        return name;
    }

    public void setName(string name)
    {
        this.name = name;
    }
}
