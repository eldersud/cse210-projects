using System;

class Program
{
    static void Main(string[] args)
    {
        // I got to be honest, for the first time I got stuck
        //so I refered to the sample solution to understan how it works.
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int num=-1;
       
       while(num != 0)
        {
            Console.Write("Enter a number: ");
        string input= Console.ReadLine();
         num= int.Parse(input);

            if(num!=0)
            {
                numbers.Add(num);
            }

        }

        int sum=0;
        foreach(int number in numbers)
        {
            sum+=number;
        }
        Console.WriteLine($"Tottal sum is: {sum}");

        float average = ((float)sum)/ numbers.Count;
        Console.WriteLine($" The average is : {average}");

        int max=numbers[0];
        foreach ( int number in numbers)
        {
            if (number>max)
            {
                max=number;
            }
        }
        Console.WriteLine($"the max is :{max}");

    }
}