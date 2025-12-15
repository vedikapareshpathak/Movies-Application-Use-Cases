using System;

namespace Movies_Application
{
    class MovieManager
    {
        private MovieCollection mCollection = new MovieCollection();

        public delegate void MovieAddAck(string message);
        public MovieAddAck MovieAdd;

        public MovieManager()
        {
            MovieAdd = ShowAcknowledgement;
        }

        private void ShowAcknowledgement(string message)
        {
            Console.WriteLine(message);
        }

        public void AddMovie(Movie movie, string language)
        {
            mCollection.AddMovie(language, movie);

            if (MovieAdd != null)
            {
                MovieAdd($"Movie '{movie.Title}' (Language: {language}) added successfully.");
            }
        }

        public void RemoveMovie(string language, Movie movie)
        {
            bool removed = mCollection.RemoveMovie(language, movie);

            if (removed)
            {
                Console.WriteLine($"Movie '{movie.Title}' has been removed from the '{language}' collection.");
            }
            else
            {
                Console.WriteLine($"Movie '{movie.Title}' does not exist in the '{language}' collection.");
            }
        }

        public void MovieCount()
        {
            Console.WriteLine($"Total movies: {mCollection.MovieCount()}");
        }
    }
}
