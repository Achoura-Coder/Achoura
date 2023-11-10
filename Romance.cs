namespace LibraryApp.Models;

public class Romance : LibraryManager
{
    private string RomanticPair { get; set; }

    public string GetRomanticPair()
    {
        return RomanticPair;
    }
    public Romance(string romanticPair)
    {
        RomanticPair = romanticPair;
    }
}
