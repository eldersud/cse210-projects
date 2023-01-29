using System;
using System.IO;
public class PromptGenerator
{
  public string DisplayPrompot(){
       int npreguntas = 1;
			string path = @"/Users/eldercuases/Documents/BYU 2023/CSE 210/cse210-projects/prove/develop02/prompt.txt";
            string[] lines = System.IO.File.ReadAllLines(path);
            foreach (string line in lines)
            {
                npreguntas++;
            }
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, npreguntas);
            //Console.WriteLine(number);
            return(lines[number-1]);

        }
    

  
} 