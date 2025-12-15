using System;
using System.Collections.Generic;
using System.Text;

namespace Movies_Application
{
    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Actor { get; set; }

        public string Actress { get; set; }

        public long Year { get; set; }

        public Movie(int id, string title, string actor, string actress, long year)
        {
            Id = id;
            Title = title;
            Actor = actor;
            Actress = actress;
            Year = year;
        }
    }
}
