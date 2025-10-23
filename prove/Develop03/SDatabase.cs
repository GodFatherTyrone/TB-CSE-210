using System.Text.Json;

public class SDatabase
{
    private string _name;
    private static readonly HttpClient client = new HttpClient();
    private string _content;

    //Create the object W/ the name
    //Run the function
    //Get the scripture
    public SDatabase(string name)
    {
        _name = name;
        _content = "";
    }
    public string Get_Scripture()
    {
        return _content;
    }
    // Async factory method to create SDatabase from API
    public async Task LoadBibleVerseAsync()
    {
        string encodedName = Uri.EscapeDataString(_name);
        string url = $"https://bible-api.com/{encodedName}?translation=kjv";

        string jsonResponse = await client.GetStringAsync(url);

        using var doc = JsonDocument.Parse(jsonResponse);
        var root = doc.RootElement;

        if (root.TryGetProperty("verses", out JsonElement verses))
        {
            string verseText = "";
            foreach (var v in verses.EnumerateArray())
            {
                verseText += v.GetProperty("text").GetString();
            }
            _content = verseText.Trim();
        }
        else
        {
            _content = "Bible verse not found.";
        }
    }
    public async Task LoadBookofMormonVerseAsync()
    {
        string encodedName = Uri.EscapeDataString(_name);
        string url = $"https://api.nephi.org/scriptures/?q={encodedName}&format=json";

        string jsonResponse = await client.GetStringAsync(url);

        using var doc = JsonDocument.Parse(jsonResponse);
        var root = doc.RootElement;

        if (root.TryGetProperty("scriptures", out JsonElement scriptures))
        {
            string verseText = "";
            foreach (var v in scriptures.EnumerateArray())
            {
                verseText += v.GetProperty("text").GetString();
            }
            _content = verseText.Trim();
        }
        else
        {
            _content = "Book of Mormon verse not found.";
        }
    }
}