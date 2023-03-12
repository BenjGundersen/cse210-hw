class BreathingActivity : Activity
{
    private string _text = "Breathe in...";
    private string _text1 = "Breathe out...";

    public BreathingActivity(string description, int activityDuration) : base(description, activityDuration)
    {
    }
    public void breathing (int seconds)
    {
        int timer = 0;
        while (timer < seconds)
        {
            Console.WriteLine("");
            Console.Write($"{_text}");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b");
                timer += 1;

            }
            Console.WriteLine("");
            Console.Write($"{_text1}");
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{i}");
                Thread.Sleep(1000);
                Console.Write("\b");
                timer += 1;
            }
            Console.WriteLine("");
            Console.WriteLine("Good job.");
            Thread.Sleep(3000);
            Console.Clear();
        }
    }

}