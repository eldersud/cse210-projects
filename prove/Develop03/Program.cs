using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("1 Nefi", 3, 7);
        var scriptureText ="And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        var scripture = new Scripture(reference, scriptureText);
        
        scripture.SetDifficulty();
        var input = "";        
        while (true) 
        {
            Console.WriteLine(scripture.GetRenderedText());
            input = Menu.GetInput();
            Console.Clear();
            if(input == "Q" || input == "q"){
                break;
            }
            if(scripture.IsCompletelyHidden()){
                break;
            }
            scripture.HideWords();
        }
    }
}