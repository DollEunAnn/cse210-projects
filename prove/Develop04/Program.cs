using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        
        do {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listening activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Int32.Parse(Console.ReadLine());

        } while(userInput != 4);
    }
}