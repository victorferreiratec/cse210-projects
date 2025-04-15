public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Abstract methods: Must be implemented by child classes.
    public abstract void RecordEvent(); // Tells what happens when the user completes the goal
    public abstract bool IsComplete(); // Check if goal is done
    public virtual string GetDetailsString() // Return a human-readable string for listing
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
        //Ex: [ ] (Say thank you) (Do it every day)
    }
    public abstract string GetStringRepresentation(); // Returns a text version of the goal (used when saving to a file).

    // A quick helper method that just returns the number of points. (necessary for GoalManager)
    public int GetPoints()
    {
        return _points;
    }

    //GetBonus Getter that will only be used for the CheckListGoal
    public virtual int GetBonus()
    {
        return 0;
    }

    //Getter for name in GoalManager
    public string GetShortName()
    {
        return _shortName;
    }


    // Stretch feature
    public void ShowCelebration()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
   _____                            _       
  / ____|                          | |      
 | |     ___  _ __   __ _ _ __ __ _| |_ ___ 
 | |    / _ \| '_ \ / _` | '__/ _` | __/ __|
 | |___| (_) | | | | (_| | | | (_| | |_\__ \
  \_____\___/|_| |_|\__, |_|  \__,_|\__|___/
                     __/ |                  
                    |___/                   
");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nCongratulations! You completed a goal!");
        Console.ResetColor();
    }
}