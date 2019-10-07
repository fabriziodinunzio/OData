using MovieLibrary;
using MovieLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MovieLibrary
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IMovieService
    {
        [OperationContract]
        IList<MovieModelDTO> GetMovies();

        [OperationContract]
        IList<MovieModelDTO> GetMoviesByTitle(string title);

        [OperationContract]
        MovieModelDTO GetMovie(int id);

        [OperationContract]
        IList<ReviewModelDTO> GetReviews(int movieId);

        [OperationContract]
        void SubmitReview(int movieId, ReviewModel review);
    }
}
