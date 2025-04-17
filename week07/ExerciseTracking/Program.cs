using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string date = DateTime.Now.ToString("dd MMM yyyy", new CultureInfo("en-US"));
        List<Activity> activities = new List<Activity>
        {
            new Running(date, 30, 4.8),
            new Cycling(date, 45, 20.0),
            new Swimming(date, 30, 40)
        };
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}