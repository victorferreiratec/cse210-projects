public class Activity
{
    private string _activityName;
    private string _activityDescription;
    protected int _activityDuration;

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _activityDuration = 1;
    }


    public void DisplayActivityDescription()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}\n");
        Console.WriteLine($"{_activityDescription}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.Clear();
        ShowStartMessage();

    }

    public void ShowStartMessage()
    {
        Console.WriteLine("Get ready...");
        ShowLoadingAnimation(5);
    }

    public void ShowEndMessage()
    {
        Console.WriteLine("Well done!!");
        ShowLoadingAnimation(5);
        Console.WriteLine($"You have completed {_activityDuration} seconds of the {_activityName}.");
        ShowLoadingAnimation(5);
        Console.Clear();
    }

    public void ShowLoadingAnimation(int duration)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };
        DateTime starTime = DateTime.Now;
        DateTime endtime = starTime.AddSeconds(duration);
        int i = 0;
        while (DateTime.Now < endtime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int duration)
    {
        for (int i = duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }


}