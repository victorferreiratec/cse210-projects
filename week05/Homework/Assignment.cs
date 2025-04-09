using System.Globalization;

public class Assignment
{
    protected string _studentName;
    private string _topic;


    // Here instead of creating getters for the variables I just made the one we would need on the other class protected with the access modifier
    //that way it is only accessable when it needs to be used for that function, if needed in the future I can change the code. :)
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}