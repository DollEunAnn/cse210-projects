using System;
using System.Linq;

// https://learn.microsoft.com/en-us/dotnet/api/system.string.join?view=net-8.0
// https://raisanenmarkus.github.io/csharp/part4/2/
// https://stackoverflow.com/questions/8474225/how-to-combine-string-to-string-with-spaces-in-between
// https://www.programiz.com/csharp-programming/arrays

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

    public void HideRandomWords(int numberToHide)
    {
        // checks of the numberToHide 
        // if numberToHide is greater than the total list count
        if (numberToHide <= _words.Count())
        {
            // loop the word in _words and set the status of some to isHidden = true
            // loop as many times as indicated to numberToHide
            int count = 0;
            while (count < numberToHide)
            {              

                count++;

            }
        }
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