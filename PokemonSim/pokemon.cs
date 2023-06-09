using System;
using System.Xml.Linq;

public abstract class Pokemon
{
    private string name;
    private string strength;
    private string weakness;
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

    public string getStrength()
    {
        return strength;
    }

    public void setStrength(string strength)
    {
        this.strength = strength;
    }

    public string getWeakness()
    {
        return weakness;
    }

    public void setWeakness(string weakness)
    {
        this.weakness = weakness;
    }

//    public bool isWeakAgainst(Pokemon other)
//    {
//        return this.getWeakness() == other.getStrength();
//    }
}
