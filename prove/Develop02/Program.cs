using System;

class Program
{
    static void Main(string[] args)
    {
       
       
        Console.WriteLine("Welcome to the Journal program");
        Console.WriteLine("Please select one of the following cvhoices");

        int nAnswer=0;

        while(nAnswer!= 5){
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");

         string answer = Console.ReadLine();
         nAnswer = int.Parse(answer);

    
         if (nAnswer==1){
            PromtGenerator objprom = new PromtGenerator();
            string prompt=(objprom.DisplayPrompot());
            Console.WriteLine(prompt);

            Entry objEntry = new Entry();
            Console.WriteLine(objEntry.DisplayEntry());
            
            
         }
         else if(nAnswer ==2){
                Console.WriteLine("write2");
         }
         else if(nAnswer ==3){
            Console.WriteLine("write3");
         }
         else if(nAnswer ==4){
            Console.WriteLine("write4");
         }
         else{
            Console.WriteLine("Thank you for visit us");
         }
        }
       }


       

        
    
}