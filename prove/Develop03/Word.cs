using System;

// underscores - https://stackoverflow.com/questions/75121857/replacing-a-string-with-an-equal-amount-of-underscores

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;

    }

    public void Hide()
    {
        _isHidden = true;

    }

    public void Show()
    {
        _isHidden = false;

    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        //string word = _isHidden ? "_____" : _text;

        if (_isHidden)
        {
            return new string('_', _text.Length);
        } 
        else
        {
            return _text;
        }     
    }    
}