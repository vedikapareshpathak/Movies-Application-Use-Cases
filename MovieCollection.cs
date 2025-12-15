using System;
using System.Collections.Generic;

namespace Movies_Application
{
    class MovieCollection
    {
        private Dictionary<string, Dictionary<int, Movie>> MoviesLang = new Dictionary<string, Dictionary<int, Movie>>();

        public void AddMovie(string language, Movie movie)
        {
            if (!MoviesLang.ContainsKey(language))
            {
                MoviesLang[language] = new Dictionary<int, Movie>();
            }

            if (!MoviesLang[language].ContainsKey(movie.Id))
            {
                MoviesLang[language].Add(movie.Id, movie);
            }
        }

        public bool RemoveMovie(string language, Movie movie)
        {
            if (MoviesLang.ContainsKey(language))
            {
                if (MoviesLang[language].ContainsKey(movie.Id))
                {
                    MoviesLang[language].Remove(movie.Id);
                    return true;
                }
            }
            return false;
        }

        public int MovieCount()
        {
            int count = 0;
            foreach (var languageMovies in MoviesLang.Values)
            {
                count += languageMovies.Count;
            }
            return count;
        }
    }
}
