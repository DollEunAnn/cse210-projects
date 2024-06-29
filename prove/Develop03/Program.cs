using System;

// https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-8.0

/** Exceed Requirements:
     - Added menu where user choose a scripture to memorize.
     - Randomly select from only those words that are not already hidden.
**/

class Program
{
    static void Main(string[] args)
    {
        string userInput = "keep_going";
        string book = "";
        int chapter = 0;
        int verse = 0;
        int endVerse = 0;
        string scriptureVerse = "";
        Reference reference;

        Console.WriteLine("Welcome to Scripture Memorizer App!");
        Console.WriteLine("Please select a scripture to start.");
        Console.WriteLine("[1] John 3:16");
        Console.WriteLine("[2] 2 Nephi 2:25");
        Console.WriteLine("[3] Proverbs 3:5-6");
        Console.Write("Enter a number: ");
        int scriptureChoice = Int32.Parse(Console.ReadLine());

        switch (scriptureChoice)
        {
            case 1:
                book = "John";
                chapter = 3;
                verse = 16;
                scriptureVerse = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
                break;
            case 2:
                book = "2 Nephi";
                chapter = 2;
                verse = 25;
                scriptureVerse = "Adam fell that men might be; and men are, that they might have joy.";
                break;
            case 3:
                book = "Proverbs";
                chapter = 3;
                verse = 5;
                endVerse = 6;
                scriptureVerse = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
                break;
            default:
                Console.WriteLine();
                Console.WriteLine("Invalid input! Please enter a number between 1 and 3.");
                Console.WriteLine();
                break;
        }

        string text = scriptureVerse;

        if (endVerse == 0)
        {
            reference = new Reference(book, chapter, verse);
        }
        else
        {
            reference = new Reference(book, chapter, verse, endVerse);
        }

        Scripture scripture = new Scripture(reference, text);

       
        Random random = new Random();

        do
        {
            // clear the console
            Console.Clear();
            Console.WriteLine();

            // display the scripture reference 
            Console.WriteLine($"{reference.GetDisplayText()}");

            // display the scripture words
            // scripture updates when enter key is pressed           
            Console.WriteLine($"{scripture.GetDisplayText()}");

            // checks user key input or text input 
            // [Enter] key will loop for random words
            // 'quit' will exit the program
            Console.WriteLine();
            Console.WriteLine("Please enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();

            // if everthing is hidden and [Enter] is pressed, quit the program
            if(!scripture.IsCompletelyHidden())
            {
                // gets a random number from the count
                var notHidden = scripture.wordsNotHidden();            

                // check if completely hidden
                scripture.HideRandomWords(random.Next(1, notHidden.Count()));

            } 
            else
            {

                userInput = "quit";
            }
            
        }   while (userInput != "quit"); 
    }
}