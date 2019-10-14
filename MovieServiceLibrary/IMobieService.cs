using MovieLibrary;
using MovieLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MovieLibrary
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IMovieService
    {
        [OperationContract]
        [WebGet(UriTemplate = "Books")]
        IList<MovieModelDTO> GetMovies();

        [OperationContract]
        [WebGet(UriTemplate = "Books/{title}")]
        IList<MovieModelDTO> GetMoviesByTitle(string title);

        [OperationContract]
        [WebGet(UriTemplate = "Books?id={id}")]
        MovieModelDTO GetMovie(int id);

        [OperationContract]
        [WebGet(UriTemplate = "Reviews?movieId={movieId}")]
        IList<ReviewModelDTO> GetReviews(int movieId);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Reviews?movieId={movieId}")]
        void SubmitReview(int movieId, ReviewModel review);
    }
}
