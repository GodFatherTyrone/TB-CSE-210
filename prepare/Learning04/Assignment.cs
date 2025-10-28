public class Assignment
{
    private string _studentName;
    private string _topic;
    public Assignment()
    {
        _studentName = "Unnamed";
        _topic = "Unknown Topic";
    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public string Get_Summary() //return the student's name and the topic.
    {
        string _summary = _studentName + " - " + _topic;
        return _summary;
        
    }
}