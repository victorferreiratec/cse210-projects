public class Word
{
    private string _text;

    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; //every word starts as not hidden
    }

    public void Hide()
    {
        _isHidden = true;
    }

    //As a stretch added the Show method
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
        if (_isHidden)
        {
            //return the word characters in a hidden format where they were replaced to _
            string hiddenWord = new string('_', _text.Length);//_____
            return hiddenWord; //____
        }
        else
        {
            //return the word as it is
            return _text;
        }
    }
}