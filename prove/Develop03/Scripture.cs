public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text)
    {   
        _reference = reference;
        foreach(string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }


    public void HideRandomWords(int numberToHide)
     {
        int showedWordCounter = 0;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                showedWordCounter += 1;
            }
        }

        if (showedWordCounter > numberToHide)
        {
            while (numberToHide > 0)
            {
                int Index = new Random().Next(0, _words.Count);

                if (!_words[Index].IsHidden())
                {
                    _words[Index].Hide();
                    numberToHide -= 1;
                }
            }
        }

        else
        {
            foreach (Word word in _words)
            {
                word.Hide();
            }
        }
    }


    public string GetDisplayText()
     {
        List<string> wordDisplayTexts = _words.Select(word => word.GetDisplayText()).ToList();
        return string.Join(" ", wordDisplayTexts);
    }

    public bool IsCompletelyHidden()
     {
        bool listHidden = true;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                listHidden = false;
            }
        }
        return listHidden;
    }

}