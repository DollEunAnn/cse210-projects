using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
        List<int> num_list = new List<int>();
        int user_number = -1;
        int total_num = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while(user_number != 0)
        {
            Console.Write("Enter number: ");
            string entered_num = Console.ReadLine();
            user_number = int.Parse(entered_num);
            
            if (user_number != 0)
            {
                num_list.Add(user_number);            
            }

        }

        foreach (int num in num_list)
        {
            total_num += num;
        }

        Console.WriteLine("The sum is: " + total_num);
        Console.WriteLine("The average is: " + num_list.Average());
        Console.WriteLine("The largest number is: " + num_list.Max());


        
    }
}