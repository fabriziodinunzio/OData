using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TestService
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IBookService
    {
        [OperationContract]
        [WebGet]
        string GetData(int value);

        [OperationContract]
        [WebGet]
        List<Book> GetBooksList();

        [OperationContract]
        [WebGet(UriTemplate = "Book/{id}")]
        Book GetBookById(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "AddBook/{name}")]
        void AddBook(string name);

        [OperationContract]
        [WebInvoke(UriTemplate = "UpdateBook/{id}/{name}")]
        void UpdateBook(string id, string name);

        [OperationContract]
        [WebInvoke(UriTemplate = "DeleteBook/{id}")]
        void DeleteBook(string id);

        // TODO: aggiungere qui le operazioni del servizio
    }
}
