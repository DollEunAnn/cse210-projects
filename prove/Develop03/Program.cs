using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string _userInput = "keep_going";
        //string text = $"And my father dwell in a tent.";
        string text = $"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        Reference _reference = new Reference("John", 3,16);
        Scripture _scripture = new Scripture(_reference, text);

        // string[] source = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        // var count = source.Count();

        Random random = new Random();

        while (_userInput != "quit")
        {        
            // clear the console
            Console.Clear();
            Console.WriteLine();

            // display the scripture reference 
            Console.WriteLine($"{_reference.GetDisplayText()}");

            // display the scripture words
            // scripture updates when enter key is pressed           
            Console.WriteLine($"{_scripture.GetDisplayText()}");

            // checks user key input or text input 
            // [Enter] key will loop for random words
            // 'quit' will exit the program
            Console.WriteLine();
            Console.WriteLine("Please enter to continue or type 'quit' to finish: ");
            _userInput = Console.ReadLine();

            // gets a random number from the count
            int randomCountToHide = random.Next(1,4);

            // check if completely hidden
            if(!_scripture.IsCompletelyHidden())
            {
                _scripture.HideRandomWords(randomCountToHide);
            }

            // if everthing is hidden and [Enter] is pressed, quit the program
            if(_scripture.IsCompletelyHidden() == true && _userInput != "quit")
            {
                Environment.Exit(0);
            }
        }        
    }
}