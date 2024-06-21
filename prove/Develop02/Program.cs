using System;

// Exceed Core Requirement:
// - Updated the GetPromptRandom Method where the prompt doesn't repeat
// - Added more prompts
// - Added word counter for everytime the user writes an entry but doesn't saves.

class Program
{
    static void Main(string[] args)
    {
        int _userInput = 0;
        string file = "";
        Journal theJournal = new Journal();
        PromptGenerator _randomPrompt = new PromptGenerator();

        do
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            _userInput = Int32.Parse(Console.ReadLine());

            switch (_userInput)
            {
                case 1:
                    // Write
                    Console.WriteLine();
                    string _prompt = _randomPrompt.GetRandomPrompt();
                    Console.WriteLine($"{_prompt}");

                    Entry _newEntry = new Entry();

                    var today = DateOnly.FromDateTime(DateTime.Now);

                    _newEntry._date = today.ToString();
                    _newEntry._entryText = Console.ReadLine();
                    _newEntry._promptText = _prompt;

                    theJournal.WordCounter(_newEntry._entryText);

                    theJournal.AddEntry(_newEntry);
                    
                    Console.WriteLine();

                    break;
                case 2:
                    // Display
                    Console.WriteLine();
                    theJournal.DisplayAll();

                    break;
                case 3:
                    // Load
                    Console.WriteLine();
                    Console.WriteLine("What is the file name?");
                    file = Console.ReadLine();
                    Console.WriteLine();

                    theJournal.LoadToFile(file);

                    break;
                case 4:
                    // Save
                    Console.WriteLine();
                    Console.WriteLine("What is the file name?");
                    file = Console.ReadLine();

                    theJournal.SaveToFile(file);
                    Console.WriteLine();

                    break;
                case 5:
                    // Quit
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using the Journal Program! See you again tomorrow!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
                    Console.WriteLine();
                    break;
            }

        } while (_userInput != 5);
    }
}