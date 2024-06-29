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
        var unhiddenWords = wordsNotHidden();
        // checks of the numberToHide 
        // if numberToHide is greater than the total list count
        if (numberToHide <= unhiddenWords.Count() && unhiddenWords.Count() != 1)
        {
            // loop the word in _words and set the status of some to isHidden = true
            // loop as many times as indicated to numberToHide
            // get the wordsNotHidden -- filter
            int count = 0;
            while (count < numberToHide)
            {
                Random random = new Random();                              
                
                int index = random.Next(unhiddenWords.Count);

                unhiddenWords[index].Hide();                    
                
                count++;
            }
        } else {

            unhiddenWords[0].Hide();

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
        // checks if all the words are hidden
        foreach(var word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    public List<Word> wordsNotHidden()
    {
         // get all the _isHidden = false
        var unhiddenWords = _words.Where(word => !word.IsHidden()).ToList();

        return unhiddenWords;
    }
}