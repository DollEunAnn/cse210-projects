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
        // Menu
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
    /**
     Displays the players current score.
    **/
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
            Console.WriteLine($"{i}. ({goal.GetDetailsString()})");
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

    /**
    Asks the user for the information about a new goal.
    Then, creates the goal and adds it to the list.
    **/
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
                SimpleGoal simpleGoal = new SimpleGoal(name, description, score);
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

    /**
    Asks the user which goal they have done and then records the event by 
    calling the RecordEvent method on that goal.
    **/
    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = Int32.Parse(Console.ReadLine());

        goalIndex = goalIndex - 1;

        _goals[goalIndex].RecordEvent();

        _score += _goals[goalIndex].GetPoints();

        Console.WriteLine($"Congratulations! You have earned {_goals[goalIndex].GetPoints()} points.");
        Console.WriteLine($"You have now {_score}.");
    }

    /**
     Saves the list of goals to a file.
     **/
    public void SaveGoals()
    {
        Console.Write("What is the filename of the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // records score
            outputFile.WriteLine(_score);

            foreach (var goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetStringSave()}");
            }
        }
    }

    /**
    Loads the list of goals from a file.
    **/
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        _goals.Clear();

        using (StreamReader inputFile = new StreamReader(fileName))
        {
            // Read the first line to get the score
            string scoreLine = inputFile.ReadLine();
            if (scoreLine != null)
            {
                _score = Int32.Parse(scoreLine.Trim());
            }

            // Read subsequent lines for each goal
            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                // Split the line by ':'
                string[] parts = line.Split(':');

                if (parts.Length == 2)
                {
                    // parts[0] contains the goal type, parts[1] contains details
                    string goalType = parts[0].Trim();
                    string goalDetails = parts[1].Trim();

                    // Split the details by ','
                    string[] goalParts = goalDetails.Split(',');

                    if (goalType.StartsWith("SimpleGoal"))
                    {

                        string name = goalParts[0].Trim();
                        string description = goalParts[1].Trim();
                        int points = Int32.Parse(goalParts[2].Trim());
                        bool isComplete = bool.Parse(goalParts[3].Trim());

                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);

                        if (isComplete)
                        {
                            simpleGoal.RecordEvent(); // Mark as completed if necessary
                        }
                        _goals.Add(simpleGoal);
                    }

                    if (goalType.StartsWith("EternalGoal"))
                    {

                        string name = goalParts[0].Trim();
                        string description = goalParts[1].Trim();
                        int points = Int32.Parse(goalParts[2].Trim());

                        EternalGoal eternalGoal = new EternalGoal(name, description, points);

                        _goals.Add(eternalGoal);
                    }

                    if (goalType.StartsWith("ChecklistGoal"))
                    {
                        string name = goalParts[0].Trim();
                        string description = goalParts[1].Trim();
                        int points = Int32.Parse(goalParts[2].Trim());
                        int target = Int32.Parse(goalParts[3].Trim());
                        int bonus = Int32.Parse(goalParts[4].Trim());
                        int amountCompleted = Int32.Parse(goalParts[5].Trim());


                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);

                        _goals.Add(checklistGoal);

                        checklistGoal.IsCompleted();

                        // records the amount completed
                        if (amountCompleted != 0)
                        {
                            for (int i = 0; i < amountCompleted; i++)
                            {
                                checklistGoal.RecordEvent();   
                            }
                        }


                    }

                }
            }
        }
    }

    public void ShowSpinner(int seconds)
    {
        string frames = @"/-\|";

        Console.CursorVisible = false;

        for (int i = seconds; i > 0; i--)
        {
            foreach (var c in frames)
            {
                Console.Write($"\b{c}");
                Thread.Sleep(300);
            }
        }
    }

}