using System;

class Scripture
{
    public Reference _reference = new Reference("John", 3,16);
    public List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {

    }

    public void HideRandomWords(int numberToHIde)
    {

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