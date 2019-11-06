using MovieLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class MovieDataSource : IMovieDataSource, IDisposable
    {
        private MovieDbContext _ctx;
        public MovieDataSource(MovieDbContext context)
        {
            _ctx = context;
        }

        public IQueryable<MovieModel> GetMovies()
        {

                return _ctx.Movies;
        }
        public MovieModel GetMovie(int id)
        {
                return _ctx.Movies.Single(m => m.Id == id);
        }
        public IQueryable<ReviewModel> GetReviews(int movieId)
        {
            return _ctx.Movies.Single(m => m.Id == movieId).Reviews.AsQueryable();
        }

        public void Save()
        {
                 _ctx.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Per rilevare chiamate ridondanti

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: eliminare lo stato gestito (oggetti gestiti).
                    _ctx.Dispose();
                }

                // TODO: liberare risorse non gestite (oggetti non gestiti) ed eseguire sotto l'override di un finalizzatore.
                // TODO: impostare campi di grandi dimensioni su Null.

                disposedValue = true;
            }
        }

        // TODO: eseguire l'override di un finalizzatore solo se Dispose(bool disposing) include il codice per liberare risorse non gestite.
        // ~MovieDataSource()
        // {
        //   // Non modificare questo codice. Inserire il codice di pulizia in Dispose(bool disposing) sopra.
        //   Dispose(false);
        // }

        // Questo codice viene aggiunto per implementare in modo corretto il criterio Disposable.
        public void Dispose()
        {
            // Non modificare questo codice. Inserire il codice di pulizia in Dispose(bool disposing) sopra.
            Dispose(true);
            // TODO: rimuovere il commento dalla riga seguente se è stato eseguito l'override del finalizzatore.
             GC.SuppressFinalize(this);
        }
        #endregion


    }
}
