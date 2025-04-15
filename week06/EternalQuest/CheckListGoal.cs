public class CheckListGoal : Goal
{
    private int _amountCompleted; // How many times this has been done
    private int _target; // How many times it needs to be done to be completed
    private int _bonus; // Bonus points when completed

    // Constructor that sets up a checklist goal with all its values.
    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0; // Start at 0
        _target = target;
        _bonus = bonus;
    }

    //Methods

    //Method that increases the progress, gives a bonus when the goal is fully done, and handles already-finished goals.
    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.Clear();
            Console.WriteLine($"Progress made! {_amountCompleted}/{_target} completed.");
            if (IsComplete())
            {
                Console.Clear();
                ShowCelebration();
                Console.WriteLine($"Bonus achieved! You earned {_bonus} bonus points!");
                Thread.Sleep(10000);
                Console.Clear();
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("This goal is already completed.");
            Console.WriteLine($"But congrats for doing it again! You have earned {_bonus} points as a bonus!");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
        // Returns true if we've done it enough times
    }

    public override string GetDetailsString()
    {
        //Using ternary-operator fills the checklist if completed
        return $"{base.GetDetailsString()} -- Currently completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }


    //Creating Setter for _amountCompleted
    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    //Getter for the bonus
    public override int GetBonus()
    {
        return _bonus;
    }
}