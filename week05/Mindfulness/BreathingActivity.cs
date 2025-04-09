public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string activityDescription) : base(activityName, activityDescription)
    {
    }

    public void StartActivity()
    {
        DisplayActivityDescription();
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_activityDuration);
        bool firstCycle = true;
        while (DateTime.Now < endTime)
        {
            if (firstCycle)
            {
                Console.Write("Breathe in... ");
                ShowCountDown(2); // First cycle: Breathe in for 2 seconds
                Console.Write("Breathe out... ");
                ShowCountDown(3); // First cycle: Breathe out for 3 seconds
                firstCycle = false; // Switch to longer cycles afterward
            }
            else
            {
                Console.Write("\nBreathe in...");
                ShowCountDown(4); // Subsequent cycles: Breathe in for 4 seconds
                Console.Write("Now breathe out...");
                ShowCountDown(6); // Subsequent cycles: Breathe out for 6 seconds
            }

            // Check if time is up before continuing the next cycle
            if (DateTime.Now >= endTime)
            {
                break;
            }
        }
        ShowEndMessage();
    }

}