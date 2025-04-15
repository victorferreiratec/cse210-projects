public class GoalManager
{
    private List<Goal> _goals = new List<Goal>(); // Creates a list to store all your goals
    private int _score = 0;  // Keeps track of total points

    // Constructor
    public GoalManager()
    {
    }

    public void Start()
    {
        bool quit = false;
        while (!quit)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goal");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1": //if (choice == "1")

                    // Handles goal creation
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string typeInput = Console.ReadLine();

                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    switch (typeInput)
                    {
                        case "1":
                            CreateGoal(new SimpleGoal(name, description, points));
                            break;
                        case "2":
                            CreateGoal(new EternalGoal(name, description, points));
                            break;
                        case "3":
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int target = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int bonus = int.Parse(Console.ReadLine());
                            CreateGoal(new CheckListGoal(name, description, points, target, bonus));
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid goal type.");
                            break;
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("The goals are:");
                    ListGoalDetails();
                    break;

                case "3":
                    Console.Write("What is the filename for the goal file? ");
                    string fileName = Console.ReadLine();
                    SaveGoals(fileName);
                    break;

                case "4":
                    Console.Write("What is the filename for the goal file? ");
                    string loadedFileName = Console.ReadLine();
                    LoadGoals(loadedFileName);
                    break;

                case "5":
                    RecordEvent();
                    break;

                case "6":
                    Console.WriteLine("Goodbye! Feel free to play again later!");
                    quit = true;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid menu option.");
                    break;
            }
        }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    public void ListGoalNames() //Prints each goal with a number and details
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails()
    {

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal(Goal goal)
    {
        // Take the goal created by the user and add to the list
        _goals.Add(goal);
        Console.Clear();
        Console.WriteLine("A new Goal created successfully!");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nWhich goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int index))
        {
            Goal goal = _goals[index - 1]; //save the goal that the user picked
            goal.RecordEvent();
            _score += (goal.IsComplete() && goal is CheckListGoal) ? goal.GetBonus() : goal.GetPoints();
        }
        else
        {
            Console.WriteLine("Invalid input.");
            return;
        }

    }


    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score); // Save score on the first line
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation()); // Save each goal on a new line
            }
        }
        Console.Clear();
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName))
        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(fileName);
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(":");
                string type = parts[0];
                string[] data = parts[1].Split(',');

                switch (type)
                {
                    case "SimpleGoal":
                        SimpleGoal sg = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                        // Directly set the _isComplete state
                        sg.SetIsComplete(bool.Parse(data[3]));
                        _goals.Add(sg);
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                    case "CheckListGoal":
                        // Format: Name, Description, Points, Bonus, Target, AmountCompleted
                        CheckListGoal cg = new CheckListGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3]));
                        // Directly set the _amountCompleted
                        cg.SetAmountCompleted(int.Parse(data[5]));
                        _goals.Add(cg);
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

}