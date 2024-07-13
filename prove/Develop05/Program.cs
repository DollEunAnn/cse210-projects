using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;

        GoalManager goalManager = new GoalManager();

        do 
        {
            Console.WriteLine();
            goalManager.DisplayPlayerInfo();
            goalManager.Start();
            userInput = Int32.Parse(Console.ReadLine());

            switch(userInput) {
                case 1: // create new goal
                goalManager.CreateGoal();
                //goalManager.ShowSpinner(2); 
                Console.WriteLine($"Saved");
                //Thread.Sleep(500);
                break;

                case 2: // list goals
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