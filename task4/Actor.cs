



public class Actor
{
    private string fullName;
    private int age;
    private string gender;
    private List<Movie> moviesPlayed;

    public Actor(string fullName, int age, string gender)
    {
        this.fullName = fullName;
        this.age = age;
        this.gender = gender;
        this.moviesPlayed = new List<Movie>();
    }
    public string GetFullName()
    {
        return fullName;
    }
    public void AddMovie(Movie movie)
    {
        moviesPlayed.Add(movie);
    }

    public List<Movie> GetMoviesPlayed()
    {
        return moviesPlayed;
    }

    public void SetAge(int age)
    {
        this.age = age;
    }

    public int GetAge()
    {
        return age;
    }

    public void SetGender(string gender)
    {
        this.gender = gender;
    }

    public string GetGender()
    {
        return gender;
    }
}