using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MovieLibrary;

namespace MovieLibrary
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice e nel file di configurazione contemporaneamente.
    public class MovieService : IMovieService
    {
        public MovieModel GetMovie(int id)
        {
            MovieModel result;
            using (MovieDbContext ds = new MovieDbContext())
            {
                result = ds.Movies.Single(m => m.Id == id);
                return result;
            }
        }

        public IQueryable<MovieModel> GetMovies()
        {
            using (MovieDbContext ds = new MovieDbContext())
            {
                IQueryable<MovieModel> result = ds.Movies;
                return result;
            }
        }

        public IQueryable<MovieModel> GetMoviesByTitle(string title)
        {
            using (MovieDbContext ds = new MovieDbContext())
            {
                return ds.Movies.Where(m => m.Title == title);
            }        
        }

        public IQueryable<ReviewModel> GetReviews(int movieId)
        {

            using (MovieDbContext ds = new MovieDbContext())
            {
                return ds.Reviews.Where(r => r.Movie.Id == movieId);
            }
        }

        public void SubmitReview(int movieId, ReviewModel review)
        {
            using (MovieDbContext ds = new MovieDbContext())
            {
                ReviewModel currentReview = review;
                MovieModel movie = ds.Movies.Single(m => m.Id == movieId);
                currentReview.Movie = movie;
                ds.Reviews.Add(currentReview);
                ds.SaveChanges();
            }
        }
    }
}
