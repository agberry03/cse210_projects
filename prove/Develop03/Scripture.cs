public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        foreach (string word in text.Split(" "))
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.GetReferenceText();

        foreach (Word word in _words)
        {
            string newText = word.GetDisplayText() + " ";
            display += newText;
        }
        return display;
    }

    public void HideWords(int number)
    {
        int i = 0;
        while (i < number)
        {
            Random rand = new Random();
            int index = rand.Next(0, _words.Count);

            // Reassign index if the word has already been hidden.
            while (_words[index].IsHidden())
            {
                index = rand.Next(0, _words.Count);

                // Check if the scripture is hidden to
                // prevent becoming stuck in the while loop.
                if (IsCompletelyHidden())
                {
                    return;
                }
            }
            Word randomWord = _words[index];

            randomWord.Hide();
            i++;
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!(word.IsHidden()))
            {
                return false;
            }
        }
        return true;
    }
}