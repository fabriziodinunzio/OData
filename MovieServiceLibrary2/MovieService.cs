using MovieLibrary;
using MovieLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieServiceLibrary2
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice e nel file di configurazione contemporaneamente.
    public class MovieService : IMovieService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public MovieModelDTO GetMovie(int id)
        {
            using (IMovieDataSource _ds = new MovieDataSource(new MovieDbContext()))
            {
                MovieModel result;
                result = _ds.GetMovies().Single(m => m.Id == id);
                return new MovieModelDTO() { Id = result.Id, Title = result.Title };
            }
        }

        public IList<MovieModelDTO> GetMovies()
        {
            using (IMovieDataSource _ds = new MovieDataSource(new MovieDbContext()))
            {
                IList<MovieModelDTO> result = _ds.GetMovies().Select(m => new MovieModelDTO()
                {
                    Id = m.Id,
                    Title = m.Title
                }).ToList<MovieModelDTO>();
                return result;
            }
        }

        public IList<MovieModelDTO> GetMoviesByTitle(string title)
        {
            using (IMovieDataSource _ds = new MovieDataSource(new MovieDbContext()))
            {
                IQueryable<MovieModel> result = _ds.GetMovies().Where(m => m.Title == title);
                return result.Select(m => new MovieModelDTO() { Id = m.Id, Title = m.Title }).ToList();
            }

        }

        public IList<ReviewModelDTO> GetReviews(int movieId)
        {
            using (IMovieDataSource _ds = new MovieDataSource(new MovieDbContext()))
            {
                IList<ReviewModel> result = _ds.GetReviews(movieId).ToList();
                return result.Select(r => new ReviewModelDTO()
                {
                    Id = r.Id,
                    Rating = r.Rating,
                    Reviewer = r.Reviewer,
                    ReviewText = r.ReviewText,
                    Summary = r.Summary
                }).ToList();
            }
        }

        public void SubmitReview(

                                    int movieId,

                                    ReviewModelDTO review
                                )
        {
            try
            {
                using (IMovieDataSource _ds = new MovieDataSource(new MovieDbContext()))
                {
                    ReviewModelDTO currentReview = review;
                    MovieModel movie = _ds.GetMovies().Single(m => m.Id == movieId);
                    ReviewModel rev = new ReviewModel() { Rating = currentReview.Rating, ReviewText = currentReview.ReviewText, Reviewer = currentReview.Reviewer, Summary = currentReview.Summary };
                    movie.Reviews.Add(rev);
                    _ds.Save();
                }
            }
            catch (Exception e)
            {
                throw new FaultException(e.Source + Environment.NewLine + e.Message);
            }
        }
    }
}
