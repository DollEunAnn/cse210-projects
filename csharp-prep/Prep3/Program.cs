using System;

class Program
{
    static void Main(string[] args)
    {
        bool passed = false;
        bool keep_going = false;

        // Main game loop
        do
        {
            int guesses_count = 0;
            Console.Write("What is the magic number? ");
            string user_magic_num = Console.ReadLine();
            int magic_num = int.Parse(user_magic_num);

            do
            {
                
                Console.Write("What is your guess? ");
                string user_guess = Console.ReadLine();
                int guess = int.Parse(user_guess);

                if (magic_num > guess)
                {
                    Console.WriteLine("Higher");
                    passed = false;
                    guesses_count += 1;

                } else if (magic_num < guess)
                {
                    Console.WriteLine("Lower");
                    passed = false;
                    guesses_count += 1;
                }
                else
                {   
                    guesses_count += 1;
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine("No of guess:" + guesses_count);
                    passed = true;
                }

            }while(passed == false);

            Console.WriteLine("Keep playing?(yes/no): ");
            string going = Console.ReadLine();
            
            if (going == "yes")
            {
                keep_going = true;
            }else
            {
                keep_going = false;
            }

        }while(keep_going);
    }
}