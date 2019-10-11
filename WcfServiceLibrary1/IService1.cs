﻿using MovieLibrary.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace WcfServiceLibrary1
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IService1
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

    // Per aggiungere tipi compositi alle operazioni del servizio utilizzare un contratto di dati come descritto nell'esempio seguente.
    // È possibile aggiungere file XSD nel progetto. Dopo la compilazione del progetto è possibile utilizzare direttamente i tipi di dati definiti qui con lo spazio dei nomi "WcfServiceLibrary1.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
