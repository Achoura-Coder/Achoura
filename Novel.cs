namespace LibraryApp.Models;

public class Novel : LibraryManager
{
    private string Genre { get; set; } 
    public string GetGenre()
    {
        return Genre;
    }
    public Novel(string genre)
    {
        Genre = genre;
    }

}
