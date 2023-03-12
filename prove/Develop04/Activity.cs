class Activity
{
    private int _activityDuration;
    private string _description;

    public Activity (string description, int activityDuration)
    {
        _description = description;
        Console.WriteLine(description);
    }

    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        for (int x = 5; x > 0; x--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public int SetDuration()
    {
        Console.WriteLine("");
        Console.WriteLine("How long do you want the activity to last (in seconds)?  ");
        int timerLength = int.Parse(Console.ReadLine());
        _activityDuration = timerLength;
        return _activityDuration;
    }

    public void GetDuration(int activityDuration)
    {
        _activityDuration = activityDuration;
    }
}