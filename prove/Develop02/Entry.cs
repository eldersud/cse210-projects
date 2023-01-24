using System;
public class Entry
{
    public string _response;
    public int _date;

    public string DisplayEntry()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Answer: ");
        string _response=Console.ReadLine();
        

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        

        return (_response);

    }
}