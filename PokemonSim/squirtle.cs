using System;

public class Squirtle : Pokemon
{
    public Squirtle(string name, string strength, string weakness) : base(name, strength, weakness)
    {
    }


    public override void battleCry()
    {
        Console.WriteLine(getName() + " uses battleCry");
        Console.WriteLine("'Squirtle eek'");
    }

}
