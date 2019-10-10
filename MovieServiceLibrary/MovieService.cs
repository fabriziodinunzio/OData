using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MovieLibrary.DTO;

namespace MovieLibrary
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice e nel file di configurazione contemporaneamente.
    public class MovieService : IMovieService
    {
        public MovieModelDTO GetMovie(int id)
        {
            using (IMovieDataSource _ds = new MovieDataSource())
            {
                MovieModel result;
                result = _ds.GetMovies().Single(m => m.Id == id);
                return new MovieModelDTO() { Id = result.Id, Title = result.Title }; 
            }
        }

        public IList<MovieModelDTO> GetMovies()
        {
            using (IMovieDataSource _ds = new MovieDataSource())
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
            using (IMovieDataSource _ds = new MovieDataSource())
            {
                IQueryable<MovieModel> result = _ds.GetMovies().Where(m => m.Title == title);
                return result.Select(m => new MovieModelDTO() { Id = m.Id, Title = m.Title }).ToList(); 
            }
    
        }

        public IList<ReviewModelDTO> GetReviews(int movieId)
        {
            using (IMovieDataSource _ds = new MovieDataSource())
            {
                IList<ReviewModel> result = _ds.GetMovies().Single(m => m.Id == movieId).Reviews.ToList();
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

                                    ReviewModel review
                                )
        {
            try
            {
                using (IMovieDataSource _ds = new MovieDataSource())
                {
                    ReviewModel currentReview = review;
                    MovieModel movie = _ds.GetMovies().Single(m => m.Id == movieId);
                    currentReview.Movie = movie;
                    movie.Reviews.Add(review);
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
