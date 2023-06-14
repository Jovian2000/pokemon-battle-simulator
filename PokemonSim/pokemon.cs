using System;
using System.Xml.Linq;
public abstract class Pokemon
{
    private string name;
    private AttributeType strength;
    private AttributeType weakness;
	private bool health;
    private int id;
    public Pokemon(string name, int id)
	{
        this.name = name;
        strength = new AttributeType();
        weakness = new AttributeType();
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
    public AttributeType getStrength()
    {
        return strength;
    }
    public void setStrength(AttributeType strength)
    {
        this.strength = strength;
    }
    public AttributeType getWeakness()
    {
        return weakness;
    }
    public void setWeakness(AttributeType weakness)
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
