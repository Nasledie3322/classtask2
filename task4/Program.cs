

Actor actor = new Actor("Duen Jonson", 35, "Male");

Movie movie1 = new Movie("Rock", 2011);
Movie movie2 = new Movie("Forsaz", 2017);

actor.AddMovie(movie1);
actor.AddMovie(movie2);
Console.WriteLine("Аcter: " + actor.GetFullName());
Console.WriteLine("Agge: " + actor.GetAge());
Console.WriteLine("Pool; " + actor.GetGender());
Console.WriteLine("filmi:");
foreach (var movie in actor.GetMoviesPlayed())
{
    Console.WriteLine("- " + movie.GetTitle() + " (" + movie.GetReleaseYear() + ")");
}