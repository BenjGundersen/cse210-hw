class Assignment 
{
    private string _studentname;
    
    private string _topic;

    public Assignment (string name, string topic)
    {
        _studentname = name;
        _topic = topic;
    }

    public string GetStudentName()
    {
        string name = _studentname;
        return name;
    }

    public string getSummary()
    {
        string text = $"{_studentname} - {_topic}";
        return text;
    }
}