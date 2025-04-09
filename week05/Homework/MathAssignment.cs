public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    // calling the parent constructor using "base"!
    public MathAssignment(string name, string topic, string textBookSection, string problems) : base(name, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}