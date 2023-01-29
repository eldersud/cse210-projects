using System;

class Program
	{
        static void Main(string[] args)
        {

            DateTime _theCurrentTime = DateTime.Now;
            Entry entryObj = new Entry();
            Journal journalobj = new Journal();
            Console.WriteLine("Welcome to the Journal program");
            Console.WriteLine("Please select one of the following cvhoices");

            int nAnswer = 0;

            while (nAnswer != 5)
            {
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.Write("What would you like to do? ");

                string answer = Console.ReadLine();
                nAnswer = int.Parse(answer);


                if (nAnswer == 1)
                {
                    PromptGenerator objprompt = new PromptGenerator();
                    String _answer = objprompt.DisplayPrompot();
                    Console.WriteLine("Write a new Entry: ");
                    Console.WriteLine(_answer);
                    string response_ans = Console.ReadLine();
                    string dateText = _theCurrentTime.ToShortDateString();
                    entryObj.memoryTemp(_answer, response_ans,dateText);
                }
                else if (nAnswer == 2)
                {
                    entryObj.Display();
                }
                else if (nAnswer == 3)
                {
                    journalobj.Load();
                }
                else if (nAnswer == 4)
                {
                    List<string> _calledList = entryObj.GetList();
                    journalobj.Save(_calledList);
                }
                else
                {
                    Console.WriteLine("Thank you for write in the journal today!");
                }
            }
        }

    }