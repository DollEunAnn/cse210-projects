using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;

        GoalManager goalManager = new GoalManager();

        do 
        {
            Console.Clear();
            Console.WriteLine();
            goalManager.DisplayPlayerInfo();
            goalManager.Start();
            userInput = Int32.Parse(Console.ReadLine());

            switch(userInput) {
                case 1: // create new goal
                Console.WriteLine("1");
                goalManager.CreateGoal();
                break;

                case 2: // list goals
                Console.WriteLine("2");
                goalManager.ListGoalNames();
                break;

                case 3: // save goals
                Console.WriteLine("3");
                goalManager.SaveGoals();
                break;

                case 4: // load goals
                Console.WriteLine("4");
                goalManager.LoadGoals();
                break;

                case 5: // record event
                Console.WriteLine("5");
                goalManager.RecordEvent();
                break;

                default:
                break;
            }
        

        }while(userInput != 6);

    }
}