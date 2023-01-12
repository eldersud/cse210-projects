using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int nGuess;
        string answer="";
       
        
        do
        {
            
        Console.WriteLine("Try to guess the number I am thinking :P");
        do
        {
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
         nGuess = int.Parse(guess);
       
        if (number > nGuess)
        {
           Console.WriteLine("Higher");
           Console.WriteLine("Try Again!");
        }
        else if (number< nGuess)
        {
            Console.WriteLine("Lower");
            Console.WriteLine("Try Again!");

        }
        else
        {
            
            Console.WriteLine("You got it");
            Console.Write("Do you want to play again?(yes/no) ");
             answer=Console.ReadLine();
             
             
        }
        } while (nGuess != number);
        if (answer == "yes")
        {
            Console.WriteLine("Nice,lets play again!");
            
        }
        else
        {
            Console.WriteLine("Thank you for playing, it was fun :)");
        }
    
        }while(answer =="yes");
        
    
    
    // here is step number 1, I think this one was harder.
    // I want to keep it to remember how I resolved it.
   
    /*    Console.Write("what is the magic number? ");
        string input = Console.ReadLine();
        int mNumber = int.Parse(input);
        int nGuess;
        do
        {
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
         nGuess = int.Parse(guess);
       
        if (mNumber > nGuess)
        {
           Console.WriteLine("Higher");
           Console.WriteLine("Try Again!");
        }
        else if (mNumber< nGuess)
        {
            Console.WriteLine("Lower");
            Console.WriteLine("Try Again!");

        }
        else{
            Console.WriteLine("You got it");
        }
        } while (nGuess != mNumber);
    */



         
        
    }

}