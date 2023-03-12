class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string getWritingInformation()
    {
        string name = GetStudentName();
        string text = $"{_title} - {name}";
        return text;
    }
}
