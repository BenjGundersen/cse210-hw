class Video 
{
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void GetComment()
    {
        int commentCount = _comments.Count();
        Console.WriteLine($"{commentCount} comments.");
        int i = 1;
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{i}. {comment._text}, -{comment._name}");
            i++;   
        }

    }
    public void GetVideo()
    {
        Console.WriteLine($"{_title}, {_author}, {_length} seconds.");
        GetComment();
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

}