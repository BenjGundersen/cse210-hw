class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
      "When was a time you overcame something difficult",
      "Think of a time when you needed help and you got it",
      "Think of something that makes you happy",
      "Think of a time when you stood up for someone else",
      "Think of a time when you did something really difficult",
      "Think of a time when you helped someone in need",
      "Think of a time when you did something truly selfless"
    };
    private List<string> _questions = new List<string>
    {
      "Why was this experience meaningful to you?",
      "Have you ever done anything like this before?",
      "How did you get started?",
      "How did you feel when it was complete?",
      "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?",
      "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?",
      "How can you keep this experience in mind in the future?"
    };
    private List<string> _usedQuestions = new List<string>();
  public ReflectionActivity(string description, int activityDuration) : base(description, activityDuration)
    {

    }

    private string GetRandomPrompt()
    {
      var random = new Random();
      int index = random.Next(_prompts.Count);
      return _prompts[index];
    }

    private string GetRandomQuestion()
    {
      var random = new Random();
      int index = random.Next(_usedQuestions.Count);
      return _usedQuestions[index];
    }

    public void ShowQuestion(int seconds)
    {
      _usedQuestions.AddRange(_questions);
      Console.Clear();
      Console.WriteLine("Ponder on the following questions as they relate to the prompt.");
      Console.Write("You will begin in...");
      for (int i = 6; i > 0; i--)
      {
        Console.Write($"{i}");
        Thread.Sleep(1000);
        Console.Write("\b");
      }
      Console.Clear();
      if (_usedQuestions.Count != 0)
      {
        while (0 < seconds)
        {
          for (int i = 0; i < seconds; i+=3)
          {
            string question = GetRandomQuestion();
            Console.WriteLine($"{question}");
            _usedQuestions.Remove(question);
            Thread.Sleep(3000);
          }

          Console.WriteLine("");
          Console.WriteLine("Good job! You have completed the reflection activity.");
          Thread.Sleep(4000);
          Console.Clear();
        }
      }
      
      
    }

    public void ShowPrompt (int seconds)
    {
      Console.WriteLine("");
      string prompt = GetRandomPrompt();
      Console.WriteLine("Please consider the following prompt:");
      Console.WriteLine($"-{prompt}-");
      Console.WriteLine("Press enter when you are ready.");

      var input = Console.ReadKey();
      if (input.Key == ConsoleKey.Enter)
      {
        ShowQuestion(seconds);
      }

    }
}