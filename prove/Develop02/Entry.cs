using System;
public class Entry
{
    public string _prompt;
    public string _response;
    public int _date;
    
    public void DisplayEntry()
    {
        Console.WriteLine($"{_prompt}");
    }
}