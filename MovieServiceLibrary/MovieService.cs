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
        private MovieDataSource ds = new MovieDataSource();
        public MovieModel GetMovie(int id)
        {
            MovieModel result;
            try
            {
                result = ds.GetMovies().Single(m => m.Id == id);
                return result;
            }
            catch (InvalidOperationException eo)
            {
                throw eo;
            }
            catch (ArgumentNullException en)
            {
                throw en;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IQueryable<MovieModel> GetMovies()
        {
            try
            {
                return ds.GetMovies();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<MovieModel> GetMoviesByTitle(string title)
        {
            try
            {
                return ds.GetMovies().Where(m => m.Title == title);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<ReviewModel> GetReviews(int movieId)
        {

            try
            {
                return ds.GetReviews().Where(r => r.Movie.Id == movieId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SubmitReview(int movieId, ReviewModel review)
        {
            MovieModel movie = ds.GetMovies().Single(m => m.Id == movieId);

            //ds.Entry(movie).State == System.Data.Entity.EntityState.Added;
        }
    }
}
