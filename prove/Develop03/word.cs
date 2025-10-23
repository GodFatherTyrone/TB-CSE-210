using System.ComponentModel;

public class Word
{
    private string _word;//words in a list, which is put into an object
    private bool _used;//have been used
    private string _blankword;

    public Word()
    {
        
        _word = "Example_Word";
        _used = false;
        _blankword = "____________";
    }
    public Word(string word)
    {
        _word = word;
        _used = false;
        int _count = word.Count();
        _blankword = "";

        for (int j = 0; j < _count; j++)
        {
            _blankword = _blankword + "_";
        }
    }
    public string Get_Word()//displays the word, 
    {
        return _word;
    }
    public bool Get_Used()//displays the used, 
    {
        return _used;
    }
    public string Get_Blankword()
    {
        return _blankword;
    }
    public void Switch_Bool()
    {
        _used = true;
    }
}