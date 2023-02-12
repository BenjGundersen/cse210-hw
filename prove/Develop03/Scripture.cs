using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<string> _words;

    public Scripture(Reference reference, string text)
    {
        // var punctuation = text.Where(Char.IsPunctuation).Distinct().ToArray();
        // var words = text.Split().Select(x => x.Trim(punctuation));
        List<string> _words = text.Split(" ").ToList();
    }

    public void HideWords(int number)
    {
        var random = new Random();
        int index = random.Next(_words.Count);
    }
    public string GetDisplayText()
    {
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return false;
    }
}