using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNum = SquareNumber(userNumber);

        DisplayResult(userName, squareNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string user_num = Console.ReadLine();

        int userNumber = int.Parse(user_num);

        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int square = userNumber * userNumber;

        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine(name + ", the square of your number is " + square);
    }

}