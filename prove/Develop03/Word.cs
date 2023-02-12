class Word
{
    private string _content;
    private bool _isHidden;

    public Word(string text)
    {
        _content = text;
        _isHidden = false;
    }

    public string GetDisplayText(string text)
    {
        int length = text.Count();
        string blank = "_";
        _content = _content.Replace($"{_content}", $"{blank[length]}");
        return _content;
    }

    public void hideWord()
    {
        _isHidden = true;
    }
    public void showWord()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
}