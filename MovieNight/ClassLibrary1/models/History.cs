using ClassLibrary1.abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.models
{
    public class History : AModel
    {
        public List<Movie> Movies
        {
            get;
            set;
        }
        public History()
        {
            Movies = new List<Movie>();
            Movies.Add(new Movie());
        }
    }
}
