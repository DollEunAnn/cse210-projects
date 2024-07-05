using System;

/** 
Exceed requirements:
 - For the get prompt in Reflecting Activity - prompt shouldn't display twice in the session.
 -

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

            switch(userInput) {
                case 1: //breathing
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayStartingMessage();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();
                break;
                case 2: // reflection
                break;
                case 3: // listing
                break;
                case 4:
                break;
                default:
                break;
            }

        } while(userInput != 4);
    }
}