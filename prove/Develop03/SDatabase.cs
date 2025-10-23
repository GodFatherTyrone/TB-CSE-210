using System.Text.Json;

public class SDatabase
{
    private static readonly HttpClient client = new HttpClient();
    private string _name;
    private string _content;
    public SDatabase(string name)
    {
        _name = name;
        _content = "";
    }
    // Async factory method to create SDatabase from API
    public async Task LoadVerseAsync()
    {
        string encodedName = Uri.EscapeDataString(_name);
        string url = $"https://bible-api.com/{encodedName}";

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
            _content = "Verse not found.";
        }
    }
    public string Get_Name()
    {
        return _name;
    }
    public string Get_Scripture()
    {
        return _content;
    }

}