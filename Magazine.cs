namespace LibraryApp.Models;

public class Magazine : LibraryManager
{
    private string PublicationDate{ get; set; }
    public string GetPublicationDate()
    {
        return PublicationDate;
    }
    public Magazine(string publicationDate)
    {
        PublicationDate = publicationDate;
    }
}
