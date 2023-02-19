public static class Menu{
    private const string _menu = "\n*** Press Enter to start hiding words. Type Q to quit ***";

     public static string GetInput(){
        Console.WriteLine($"{_menu}");
        return Console.ReadLine();
    }
}