using System;

/** 
Exceed requirements:
 - For the get prompt in Reflecting Activity - prompt shouldn't display twice in the session.

**/
class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        
        do {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listening activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Int32.Parse(Console.ReadLine());

            Activity activity = new Activity("Trial", "Test", 10);

            activity.DisplayStartingMessage();
            activity.ShowSpinner(3);
            activity.DisplayEndingMessage();

        } while(userInput != 4);
    }
}