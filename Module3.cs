using System;

class Program
{
    static void Main()
    {
        Octopus o = new Octopus();
        o.Name = "Hank";
        o.Age = 3;

        Console.WriteLine("Name: " + o.Name);
        Console.WriteLine("Age: " + o.Age);
        Console.WriteLine("Legs: " + Octopus.Legs);
    }
}

class Octopus
{
    public string Name;
    public int Age;

    public static readonly int Legs = 8;
}
