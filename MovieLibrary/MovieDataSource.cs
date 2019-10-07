using MovieLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class MovieDataSource : IMovieDataSource
    {
        private MovieDbContext _ctx;
        public MovieDataSource()
        {
            _ctx = new MovieDbContext();
        }

        public IQueryable<MovieModel> GetMovies()
        {

                return _ctx.Movies;
        }
        public MovieModel GetMovie(int id)
        {
                return _ctx.Movies.Single(m => m.Id == id);
        }
        public IQueryable<ReviewModelDTO> GetReviews()
        {
                return _ctx.Reviews.Select(r => new ReviewModelDTO() 
                { 
                    Id = r.Id, 
                    Rating = r.Rating, 
                    Reviewer = r.Reviewer, 
                    ReviewText = r.ReviewText, 
                    Summary = r.Summary 
                });  
        }

        public void Save()
        {
                 _ctx.SaveChanges();
        }

        public void Dispose()
        {
            _ctx.Dispose();
        }
    }
}
