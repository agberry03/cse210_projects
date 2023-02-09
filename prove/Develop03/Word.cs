public class Word
{
    private string _content;
    private bool _isHidden = false;

    public Word(string word)
    {
        _content = word;
    }

    public void Hide()
    {
        _isHidden = true;
        foreach (char part in _content)
        {
            _content = _content.Replace(part, '_');
        }
    }

    public bool IsHidden()
    {
        if (_isHidden)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        return _content;
    }
}