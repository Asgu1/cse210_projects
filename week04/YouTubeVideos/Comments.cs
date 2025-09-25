public class Comment
{
    string _author = "";
    string _text = "";

    public Comment()
    {

    }
    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }
    
        public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
        public string GetText()
    {
        return _text;
    }
    public void SetText(string text)
    {
        _text = text;
    }

}