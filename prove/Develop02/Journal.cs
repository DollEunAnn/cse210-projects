using System;
using System.IO;

// Reference used for word count: https://learn.microsoft.com/en-us/dotnet/csharp/linq/how-to-query-strings (How to count occurrences of a word in a string);
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry _entry in _entries)
        {
            _entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        string fileName = file;

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry _entry in _entries)
            {
                outputFile.WriteLine($"{_entry._date}, {_entry._promptText}, {_entry._entryText}");
            }
        }
    }

    public void LoadToFile(string file)
    {
        string fileName = file;
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string _date = parts[0];
            string _promptText = parts[1];
            string _entryText = parts[2];

            Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
            Console.WriteLine($"{_entryText}");
            Console.WriteLine();
        }
    }

    public void WordCounter(string entry)
    {
        string text = entry; 

        //Convert the string into an array of words
        char[] separators = ['.', '?', '!', ' ', ';', ':', ','];
        string[] source = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        var count = source.Count();

        Console.WriteLine($"Word Count: {count}");
    }
}