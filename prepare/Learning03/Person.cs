public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;
    /*Old example
    public string GetFirstName()
    {
        return _firstName;
    }
    public void SetFirstName(string firstName)
    {
        _firstName = firstName;
    }
    */
    public Person()
    {
        _title = "";
        _firstName = "Anonymous";
        _lastName = "Unknown";
    }
    public Person(string first, string last)
    {
        _title = "";
        _firstName = first;
        _lastName = last;
    }

    public Person(string title, string first, string last)
    {
        _title = title;
        _firstName = first;
        _lastName = last;
    }

    
    
}