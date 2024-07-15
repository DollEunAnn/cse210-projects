using System;

/**
Exceed Requirements:
- Added spinner
**/
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
                goalManager.ShowSpinner(2);
                break;

                case 2: // list goals
                goalManager.ListGoalDetails();
                goalManager.ShowSpinner(2);
                break;

                case 3: // save goals
                goalManager.SaveGoals();
                goalManager.ShowSpinner(2);
                break;

                case 4: // load goals
                goalManager.LoadGoals();
                goalManager.ShowSpinner(2);
                break;

                case 5: // record event
                goalManager.ListGoalNames();
                goalManager.RecordEvent();
                goalManager.ShowSpinner(2);
                break;

                default:
                break;
            }           
        

        }while(userInput != 6);

    }
}