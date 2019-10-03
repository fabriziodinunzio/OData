using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class MovieDataSource : MovieDbContext, IMovieDataSource
    {
        public IQueryable<MovieModel> GetMovies()
        {
            return base.Movies;
        }

        public IQueryable<ReviewModel> GetReviews()
        {
            return base.Reviews;
        }

        public int Save()
        {
            return base.SaveChanges();
        }
    }
}
