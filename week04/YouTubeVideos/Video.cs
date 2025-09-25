public class Video
{
    private string _title = "";
    private string _author = "";
    private int _lenght = 0;
    private List<Comment> _comments = new List<Comment>();

    public Video()
    {

    }

    public Video(string title, string author, string lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetLenght()
    {
        return _lenght;
    }
    public void SetLenght(string lenght)
    {
        _lenght = lenght;
    }

    public void NewComment(string author, string text)
    {
        Comment newComment = new Comment(author, text);
        _comments.Add(newComment);
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public void Display()
    {
        int commentsNumbers = _comments.Count;
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Lenght(seconds): {_lenght}");
        Console.WriteLine($"Number of comments: {commentsNumbers}");
        foreach
    }
}