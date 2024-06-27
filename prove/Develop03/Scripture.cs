using System;

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

        return " ";

    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}