using System.ComponentModel;

public class GoalManager
{
    private List<Goal> _goalList = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start() 
    {
        
        int userOption = 0;

        while (userOption != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goal");
            Console.WriteLine("\t4. Load Goal");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            userOption = int.Parse(userInput);

            switch (userOption)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveToFile();
                    break;
                case 4:
                    LoadFromFile();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Please select an option from the menu (1-6)");
                    break;
            }
        }

    }
    public void DisplayPlayerInfo() 
    {
        
        Console.WriteLine($"You have {_score} points");
    }
    public void ListGoal() 
    {
        
        Console.Write("ListGoalNames...");
        int index = 1;
        Console.Write("The goals are: ");
        foreach (Goal goal in _goalList)
        {
            Console.WriteLine($"{index}. {goal.GetGoalName()}");
            index++;
        }
    }
    public void ListGoalDetails() 
    {
        if (_goalList.Count == 0)
        {
            Console.WriteLine("There are no current goals. Add one through the menu to see them in this section.");
            return;
        }
       
        int index = 1;
        Console.Write("The goals are: ");
        foreach (Goal goal in _goalList)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }
    public void CreateGoal() 
    {
        // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.WriteLine("");

        Console.Write("What type of goal would you like to create?: ");
        string goalOption = Console.ReadLine();
        int goalType = int.Parse(goalOption);

        Console.WriteLine("");
        Console.Write("What is the name of your goal?");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description?");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?");
        int goalPoints = int.Parse(Console.ReadLine());

        Goal newGoal;
        if (goalType == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus?");
            int goalTarget = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?");
            int goalBonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
        } else if (goalType == 3)
        {
            newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
        } else 
        {
            newGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
        }

        _goalList.Add(newGoal);
    }

    public void RecordEvent() 
    {
        
        ListGoal();
        
        Console.WriteLine("");
        Console.Write("Which of the goals did you accomplish? ");
        string userInput = Console.ReadLine();
        int goalIndex = int.Parse(userInput) - 1;

        int pointsObtained = _goalList[goalIndex].RecordEvent();
        _score = _score + pointsObtained;

        Console.WriteLine($"You now have {_score} points.");
    }
private void SaveToFile() 
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine() + ".txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goalList)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadFromFile() 
    {
        _goalList.Clear();

        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine() + ".txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts.Length == 1)
            {
                _score = Convert.ToInt32(parts[0]);
            }
            else if (parts.Length == 4)
            {
                _goalList.Add(new SimpleGoal(parts[0], parts[1], Convert.ToInt32(parts[2]), Convert.ToBoolean(parts[3])));
            }
            else if (parts.Length == 3)
            {
                _goalList.Add(new EternalGoal(parts[0], parts[1], Convert.ToInt32(parts[2])));
            }
            else if (parts.Length == 6)
            {
                _goalList.Add(new ChecklistGoal(parts[0], parts[1], Convert.ToInt32(parts[2]), Convert.ToInt32(parts[3]), Convert.ToInt32(parts[4]), Convert.ToInt32(parts[5])));
            }
        }
    }
}
