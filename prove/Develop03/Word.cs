public class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string text)
    {
        _text = text;
    }



    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden =false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string notext = "";
            foreach (char letter in _text)
            {
                notext += "_";
            }
            return $"{notext}";
        }
        else
        {
            return $"{_text}";
        }
    }
       

}