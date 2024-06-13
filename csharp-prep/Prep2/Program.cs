using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string user_percentage = Console.ReadLine();
        int percentage = int.Parse(user_percentage);

        string letter;

        // A >= 90
        // B >= 80
        // C >= 70
        // D >= 60
        // F < 60

        if (percentage >= 90) 
        {
            letter = "A";

        }else if(percentage >= 80)
        {
            letter = "B";

        }else if(percentage >= 70)
        {
            letter = "C";

        }else if(percentage >= 60)
        {
            letter = "D";

        }else
        {
            letter = "F";
        }

        Console.WriteLine(letter);

        // Message
        if (percentage >= 70)
        {
            Console.WriteLine("You passed! Congrats!");
        }else
        {
            Console.WriteLine("You can do it next time!. Good luck.");
        }
    }
}