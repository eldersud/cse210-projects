using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your grade ? ");
        string inputGrade = Console.ReadLine();
        int nGrade = int.Parse(inputGrade);
        
        //I tried to get the + and - by operation but I couldn't figure it out
        //so I did it my own way, I hope in the future hit that precedure!!
        //float divGrade = nGrade / 10;
        
        
        string letter ="";
        string messageOne="";


        if (nGrade >= 93 && nGrade <= 100)
        {
            letter = "A";
        }
        else if (nGrade <93 && nGrade>=90)
        {
            letter = "A-";
        }
        //this line here displays a message in case someone answer above 100
        else if (nGrade > 100)
        {
            letter="to remember grades are between 100 and 0";
        }
        
        else if (nGrade >=87 && nGrade <90)
        {
            letter = "B+";
        }
        else if (nGrade <87 && nGrade>=83)
        {
            letter = "B";
        }
        else if (nGrade <83 && nGrade>= 80)
        {
            letter = "B-";
        }
        else if (nGrade >=77 && nGrade <80)
        {
            letter = "C+";
        }
        else if (nGrade <77 && nGrade>=73)
        {
            letter = "C";
        }
        else if (nGrade <73 && nGrade>= 70)
        {
            letter = "C-";
        }
        else if (nGrade >=67 && nGrade <70)
        {
            letter = "D+";
        }
        else if (nGrade <67 && nGrade>=63)
        {
            letter = "D";
        }
        else if (nGrade <63 && nGrade>= 60)
        {
            letter = "D-";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"You got {letter}");

        if ( nGrade >= 80 && nGrade <= 100)
        {
            messageOne="You are awsome!! Good Job";
        }
        else if ( nGrade >= 70 && nGrade<80)
        {
            messageOne="well done, but you need to work harder!";
        }
        else if(nGrade<70)
        {
            messageOne="You must work harder next time";
        }
        Console.WriteLine(messageOne);


        if (nGrade >=70 && nGrade <=100)
        {
            Console.WriteLine("You pass the class");
        }
        else if (nGrade >100) 
        {
            Console.WriteLine("try again!");
        } 
        else 
        {
            Console.WriteLine("You must repeat this class, but don't give up!");
        } 
        
        
        


    }
}