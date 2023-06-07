using System;
public class Charmander : Pokemon
{

	public Charmander(string name, string strength, string weakness) : base(name, strength, weakness)
	{
	}


    public override void battleCry()
    {
        Console.WriteLine(getName() + " uses battle cry");
        Console.WriteLine("'Charmander rawr'");
    }

}