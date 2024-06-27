using System;
using System.Linq;

// https://learn.microsoft.com/en-us/dotnet/api/system.string.join?view=net-8.0
// https://raisanenmarkus.github.io/csharp/part4/2/
// https://stackoverflow.com/questions/8474225/how-to-combine-string-to-string-with-spaces-in-between

class Scripture
{
    private Reference _reference = new Reference("John", 3,16);
    private List<Word> _words = new List<Word>();        

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHIde)
    {
        
    }

    public string GetDisplayText()
    {
       List<string> displayWords = new List<string>();

       foreach(var word in _words)
       {
            displayWords.Add(word.GetDisplayText());
       }

       string output = string.Join(" ", displayWords.Where(s => !String.IsNullOrEmpty(s)));      
       
        return output;

    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}