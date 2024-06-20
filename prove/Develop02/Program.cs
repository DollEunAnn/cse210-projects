using System;

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
            Console.WriteLine("What would you like to do?");

            _userInput = Int32.Parse(Console.ReadLine());

            switch (_userInput)
            {
                case 1:
                    // Write    

                    string _prompt = _randomPrompt.GetRandomPrompt();
                    Console.WriteLine($"{_prompt}");

                    Entry _newEntry = new Entry();

                    var today = DateOnly.FromDateTime(DateTime.Now);

                    _newEntry._date = today.ToString();
                    _newEntry._entryText = Console.ReadLine();
                    _newEntry._promptText = _prompt;

                    theJournal.AddEntry(_newEntry);

                    break;
                case 2:
                    // Display

                    theJournal.DisplayAll();

                    break;
                case 3:
                    // Load
                    Console.WriteLine("What is the file name?");
                    file = Console.ReadLine();

                    theJournal.LoadToFile(file);

                    break;
                case 4:
                    // Save

                    Console.WriteLine("What is the file name?");
                    file = Console.ReadLine();

                    theJournal.SaveToFile(file);

                    break;
                case 5:
                    // Quit
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 5.");
                    break;
            }

        } while (_userInput != 5);
    }

}