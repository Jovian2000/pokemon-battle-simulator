using System;
using System.Xml.Linq;
public abstract class Pokemon
{
    private string name;
    private AttributeTypes strength;
    private AttributeTypes weakness;
	private bool health;
    private int id;
    public Pokemon(string name, int id)
	{
        this.name = name;
        strength = new AttributeTypes();
        weakness = new AttributeTypes();
        health = true;
        this.id = id;
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
    public AttributeTypes getStrength()
    {
        return strength;
    }
    public void setStrength(AttributeTypes strength)
    {
        this.strength = strength;
    }
    public AttributeTypes getWeakness()
    {
        return weakness;
    }
    public void setWeakness(AttributeTypes weakness)
    {
        this.weakness = weakness;
    }
    public bool getHealth()
    {
        return health;
    }
    public void setHealth(bool health)
    {
        this.health = health;
    }
    public int getId()
    {
        return id;
    }
    public void setId(int id)
    {
        this.id = id;
    }
    //    public bool isWeakAgainst(Pokemon other)
    //    {
    //        return this.getWeakness() == other.getStrength();
    //    }
}
