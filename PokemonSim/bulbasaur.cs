using System;

public class Bulbasaur : Pokemon
{

    public Bulbasaur(string name, string strength, string weakness) : base(name, strength, weakness)
    {
    }


    public override void battleCry()
    {
        Console.WriteLine(getName() + " uses battleCry");
        Console.WriteLine("'Bulbasaur craawww'");
    }

}