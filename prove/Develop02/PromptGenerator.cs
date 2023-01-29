class PromptGenerator
{
    public static string[] _prompt =
    {
        "What was your favorite part of the day?",
        "Did you see any blessings today?",
        "What did you have for dinner?",
        "What is your dream vacation spot?",
        "Did you read a book today?",
        "Did you watch a movie today?",
        "What did you do today?",
        "Did you meet someone new today?"
    };
    public List<string> _prompts = new List<string>(_prompt);

    public string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }
}