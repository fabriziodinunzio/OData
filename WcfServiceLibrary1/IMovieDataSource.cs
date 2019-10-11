using MovieLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    public interface IMovieDataSource : IDisposable
    {
        IQueryable<MovieModel> GetMovies();
        IQueryable<ReviewModelDTO> GetReviews();
        void Save();
    }
}
