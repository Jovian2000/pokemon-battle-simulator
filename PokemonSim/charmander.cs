using System;
public class Charmander : Pokemon
{
	public Charmander(string name, int id) : base(name, id)
	{
        setStrength(AttributeType.Fire);
        setWeakness(AttributeType.Water);
	}
    public override void battleCry()
    {
        Console.WriteLine(getName() + " uses battle cry");
        Console.WriteLine("'Charmander rawr'");
    }
}