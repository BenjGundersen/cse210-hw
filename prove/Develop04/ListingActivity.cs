class ListingActivity : Activity
{
  private List<string> _prompts = new List<string>
   {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };

  public ListingActivity(string description, int activityDuration) : base(description, activityDuration)
    {
    }

    private string GetRandomPrompt()
    {
      var random = new Random();
      int index = random.Next(_prompts.Count());
      return _prompts[index];
    }

    public void ReturnPrompt(int seconds)
    {
      Console.WriteLine("");
      string question = GetRandomPrompt();
      Console.WriteLine("List as many responses as you can think of to the following question");
      Console.WriteLine($"{question}");

      while (0 < seconds)
        {
          for (int i = 0; i < seconds; ++i)
          {
            Thread.Sleep(1000);
            Console.Write("> ");
            Console.ReadLine();
          }

        }
        Console.WriteLine("");
        Console.WriteLine("Good job! You have completed the listing activity.");
        Thread.Sleep(4000);
        Console.Clear();
    }



}