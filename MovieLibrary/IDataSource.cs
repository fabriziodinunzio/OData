using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    interface IMovieDataSource
    {
        IQueryable<MovieModel> GetMovies();
        IQueryable<ReviewModel> GetReviews();
    }
}
