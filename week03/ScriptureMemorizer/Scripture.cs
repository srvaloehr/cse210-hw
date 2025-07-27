//Stephen - cse210

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>(); // new list

        string[] parts = text.Split(' '); 
        foreach (string word in parts)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);

            while (_words[index].IsHidden())
            {
                index = random.Next(_words.Count);
            }
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        Console.Write(_reference.GetDisplayText());
        return " " + text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}