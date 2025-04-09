public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    public ReflectingActivity(string activityName, string activityDescription, List<string> promptsList, List<string> questionsList) : base(activityName, activityDescription)
    {
        _prompts = promptsList;
        _questions = questionsList;
    }


    public void StartActivity()
    {
        DisplayActivityDescription();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {ShowRandomPhrases(_prompts)} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        ShowQuestions();
        ShowEndMessage();


    }

    public string ShowRandomPhrases(List<string> listOfPhrases)
    {
        Random rand = new Random();
        int index = rand.Next(listOfPhrases.Count);
        return $"{listOfPhrases[index]}";
    }

    public void ShowQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_activityDuration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"{ShowRandomPhrases(_questions)} ");
            ShowLoadingAnimation(10);

            // Check if time is up before continuing the next cycle
            if (DateTime.Now >= endTime)
            {
                break;
            }
        }
    }


}