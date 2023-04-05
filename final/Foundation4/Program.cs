using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        DateTime date = DateTime.Now;
        string stringDate = date.ToShortDateString();

        activities.Add(new Running(stringDate, 40, 5));
        activities.Add(new Bicycle(stringDate, 120, 20));
        activities.Add(new Swimming(stringDate, 15, 2));
        foreach (Activity activity in activities)
        {
        activity.GetSummary();
        }
    }
}