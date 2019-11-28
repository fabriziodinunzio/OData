using MovieLibrary;
using MovieLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MovieServiceLibrary2
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IMovieService
    {
        // TODO: aggiungere qui le operazioni del servizio
       
            [OperationContract]
            [WebGet(UriTemplate = "Movies")]
            IList<MovieModelDTO> GetMovies();

            [OperationContract]
            [WebGet(UriTemplate = "Movies/{title}")]
            IList<MovieModelDTO> GetMoviesByTitle(string title);

            [OperationContract]
            [WebGet(UriTemplate = "Movies?id={id}")]
            MovieModelDTO GetMovie(int id);

            [OperationContract]
            [WebGet(UriTemplate = "Reviews?movieId={movieId}")]
            IList<ReviewModelDTO> GetReviews(int movieId);

            [OperationContract]
            [WebInvoke(UriTemplate = "Reviews?movieId={movieId}")]
            ReviewModelDTO SubmitReview( int movieId, ReviewModelDTO review);
         
            [OperationContract]
            [WebGet]
            string GetData(int value);
    }
}
