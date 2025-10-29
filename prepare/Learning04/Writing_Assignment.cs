public class Writing_Assignment : Assignment 
{
    private string _title;
    public Writing_Assignment() : base()
    {
        _title = "Unknown Title";
    }
    public Writing_Assignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
    public string Get_Writing_Information()
    {
        return _title;
    }
}