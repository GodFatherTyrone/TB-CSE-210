public class Math_Assignment : Assignment 
{
    private string _textbookSection;
    private string _problems;
    public Math_Assignment() : base()
    {
        _textbookSection = "Unknown Booksection";
        _problems = "Problems Unknown";
    }
    public Math_Assignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }
    public string Get_Homeworklist()
    {
        string _homeworklist = _textbookSection + " " + _problems;
        return _homeworklist;
    }
}