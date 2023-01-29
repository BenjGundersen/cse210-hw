using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();
    

    public void Save(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
               outputFile.WriteLine($"{entry._date}__{entry._prompt}__{entry._text}"); 
            }
        }
        Console.WriteLine($"Journal saved as {file}.txt");
    }
    public void Load(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("__");
            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            Entry theEntry = new Entry();
            theEntry._date = date;
            theEntry._prompt = prompt;
            theEntry._text = text;
            _entries.Add(theEntry);
            
        }
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Displaying entries:");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}