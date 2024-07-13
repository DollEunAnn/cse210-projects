using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;

    }

    public void Start()
    {
        // menu
        Console.WriteLine();
        Console.WriteLine("Menu Options");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from menu: ");

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
    }

    /**
    Lists the names of each of the goals.
    **/
    public void ListGoalNames()
    {
        int i = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
        
    }

    /**
     Lists the details of each goal (including the checkbox of whether it is complete).
     **/
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        int i = 1;

        foreach (var goal in _goals)
        {
            string if_completed = goal.IsCompleted() ? "[X]" : "[ ]";
            Console.WriteLine($"{i}. {if_completed} {goal.GetStringRepresentation()}");
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The type of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int input = Int32.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is the short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int score = Int32.Parse(Console.ReadLine());

        switch (input)
        {
            case 1: // simple
                SimpleGoal simpleGoal = new SimpleGoal(name,description,score);
                _goals.Add(simpleGoal);
                break;

            case 2: // eternal
                EternalGoal eternalGoal = new EternalGoal(name, description, score); 
                 _goals.Add(eternalGoal);
                break;

            case 3: // checklist
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = Int32.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing this goal? ");
                int bonus = Int32.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, score, target, bonus); 
                 _goals.Add(checklistGoal);
                break;

            default:
                Console.WriteLine("Please enter vaules from 1 - 3");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? ");
        int goalIndex = Int32.Parse(Console.ReadLine());

        goalIndex = goalIndex - 1;

        _goals[goalIndex].RecordEvent();

    }

    public void SaveGoals()
    {
        Console.Write("What is the filename of the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }

    }

    public void LoadGoals()
    {

    }

    public void ShowSpinner(int seconds)
    {
        string frames = @"/-\|";

        Console.CursorVisible = false;

        for(int i = seconds; i > 0; i--)
        {
            foreach(var c in frames)
            {
                Console.Write($"\b{c}");
                Thread.Sleep(300);
            }
        }
    }

}