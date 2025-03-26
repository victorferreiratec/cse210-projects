public class PromptGenerator
{

    public List<string> _prompts = new List<string>
    {
        "How was your day today?",
        "What made you happy today?",
        "Did anything make you feel frustrated or sad? Why?",
        "What is something new you learned today?",
        "What are you grateful for today?",
        "Did you have an interesting conversation? What was it about?",
        "What are your goals for tomorrow?",
        "Describe a place you went to today. How did it make you feel?",
        "What is something you wish you had done differently today?",
        "If you could give advice to your future self, what would it be?"
    };

    //Constructor
    public PromptGenerator()
    {
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int randomIndex = rand.Next(_prompts.Count);
        string selectedPrompt = _prompts[randomIndex];
        return selectedPrompt;
    }
}