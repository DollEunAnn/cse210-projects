using System;

/** 
Exceed requirements:
 - For the get prompt in Reflecting Activity - Make sure no random prompts/questions are selected until they have all been used at least once in that session.
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
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.DisplayStartingMessage();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();
                break;
                case 3: // listing
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayStartingMessage();
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();
                break;
                case 4:
                break;
                default:
                break;
            }

        } while(userInput != 4);
    }
}