


public class Movie
{
    private string title;
    private int releaseYear;

    public Movie(string title, int releaseYear)
    {
        this.title = title;
        this.releaseYear = releaseYear;
    }

    public string GetTitle()
    {
        return title;
    }

    public int GetReleaseYear()
    {
        return releaseYear;
    }
}