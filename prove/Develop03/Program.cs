using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string _userInput = "keep_going";

        Reference _reference = new Reference("John", 3,16);

        //string text = $"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";

        string text = $"And my father dwell in a tent.";

        Scripture _scripture = new Scripture(_reference, text);


        while (_userInput != "quit")
        {        
            // clear the console
            Console.Clear();
            Console.WriteLine();

            // display the scripture reference 
            Console.WriteLine($"{_reference.GetDisplayText()}");

            // display the scripture words           
            Console.WriteLine($"{_scripture.GetDisplayText()}");

            // checks user key input or text input 
            // [Enter] key will loop for random words
            // 'quit' will exit the program
            Console.WriteLine();
            Console.WriteLine("Please enter to continue or type 'quit' to finish: ");
            _userInput = Console.ReadLine();


        }        
    }
}