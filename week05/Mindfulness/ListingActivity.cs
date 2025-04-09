public class ListingActivity : Activity
{
    private List<string> _listOfPrompts = new List<string>();
    private int _count;

    public ListingActivity(string activityName, string activityDescription, List<string> prompts) : base(activityName, activityDescription)
    {
        _listOfPrompts = prompts;
        _count = 0;
    }


    public void StartActivity()
    {
        DisplayActivityDescription();
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(_activityDuration);
        Console.WriteLine("List as many responses you can to the following prompt:");
        ShowRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} itens!\n");
        _count = 0;
        ShowEndMessage();
    }

    public void ShowRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_listOfPrompts.Count);
        Console.WriteLine($"--- {_listOfPrompts[index]} ---");
    }


}