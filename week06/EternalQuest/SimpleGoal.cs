public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            Console.Clear();
            ShowCelebration();
            Console.WriteLine($"You have earned {_points} points!");
            Thread.Sleep(10000);
            Console.Clear();
            _isComplete = true;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("This goal is already completed.");
            Console.WriteLine($"But congrats for doing it again! You have earned {_points} points!");

        }
    }

    //Setter for isComplete
    public void SetIsComplete(bool completed)
    {
        _isComplete = completed;
    }


    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}