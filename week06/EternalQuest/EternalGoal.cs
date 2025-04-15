public class EternalGoal : Goal
{
    // Calls the base class constructor to initialize fields
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    // When the user completes this goal, we just print a congratulation message
    public override void RecordEvent()
    {
        Console.Clear();
        ShowCelebration();
        Console.WriteLine($"You have earned {_points} points!");
        Thread.Sleep(10000);
        Console.Clear();
    }

    public override bool IsComplete()
    {
        return false; // This goal is never complete — it's eternal!
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
        // Returns a text version of the goal (used when saving to a file).
    }
}