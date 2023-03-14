public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void GetVideoDetails()
    {
        Console.WriteLine($"{_title} by {_author} - length: {_length} sec. Number of comments: {_comments.Count()}");

        Console.WriteLine("Comments:");
        int i = 1;
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"{i}. {comment.GetName()} - \"{comment.GetText()}\"");
            i++;
        }
    }
    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }
}