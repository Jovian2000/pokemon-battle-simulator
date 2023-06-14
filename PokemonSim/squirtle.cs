using System;
public class Squirtle : Pokemon
{
    public Squirtle(string name, int id) : base(name, id)
    {
        setStrength(AttributeType.Water);
        setWeakness(AttributeType.Grass);
    }
    public override void battleCry()
    {
        Console.WriteLine(getName() + " uses battleCry");
        Console.WriteLine("'Squirtle eek'");
    }
}