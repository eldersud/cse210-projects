using System;

class Program
{
    static void Main(string[] args)
    {
        //week One - activity 1
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();
        Console.WriteLine($"Your name is {lname}, {name} {lname}.");

    }
}