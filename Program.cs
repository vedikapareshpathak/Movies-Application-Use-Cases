using System;
using Movies_Application;

class Program
{
    static void Main(string[] args)
    {
        MovieManager manager = new MovieManager();

        Movie h1 = new Movie(1, "3 Idiots", "Amir Khan", "Kareena Kapoor", 2009);
        Movie t1 = new Movie(2, "Bahubali", "Prabhas", "Anushka Shetty", 2017);
        Movie t2 = new Movie(3, "Pushpa", "Allu Arjun", "Rashmika Mandanna", 2021);

        manager.AddMovie(h1, "Hindi");
        manager.AddMovie(t1, "Telugu");
        manager.AddMovie(t2, "Telugu");

        manager.MovieCount();

        Movie h2 = new Movie(3, "YJHD", "Ranbir Kapoor", "Deepika", 2013);
        manager.AddMovie(h2, "Hindi");
        manager.MovieCount();

        Console.WriteLine("Trying to remove a movie:");
        manager.RemoveMovie("Hindi", h1);
        manager.MovieCount();
    }
}
