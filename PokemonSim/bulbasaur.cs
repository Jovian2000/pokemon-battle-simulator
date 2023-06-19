using System;
public class Bulbasaur : Pokemon
{
    public Bulbasaur(string name, int id) : base(name, id)
    {
        setStrength(AttributeTypes.Grass);
        setWeakness(AttributeTypes.Fire);
    }
    public override void battleCry()
    {
        Console.WriteLine(getName() + " uses battleCry");
        Console.WriteLine("'Bulbasaur craawww'");
    }
}