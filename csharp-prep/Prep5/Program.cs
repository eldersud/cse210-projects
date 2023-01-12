using System;

class Program
{
    static void Main(string[] args)
    {
        //I relized I did it very different this time,
        //I learned a lot after reviewingn sample solution.
        DisplayWelcome ();
        
        DisplayResult();
    }
    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName= Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite Number? ");
        string userNumber= Console.ReadLine();
        int number = int.Parse(userNumber);
        
        return number;
    }
    static int SquareNumber(int number)
    {

        double square = Math.Pow(number,2);
        int result = Convert.ToInt32(square);
        return result;
    }
    static void DisplayResult()
    {
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        Console.WriteLine($"{userName}, the square of your favorite number is {square}.");
    }
}