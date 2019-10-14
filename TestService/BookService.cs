using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestService
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice e nel file di configurazione contemporaneamente.
    public class BookService : IBookService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Book> GetBooksList()
        {
            using (BookDbEntities entities = new BookDbEntities())
            {
                return entities.Books.ToList();
            }
        }

        public Book GetBookById(string id)
        {
            try
            {
                int bookId = Convert.ToInt32(id);

                using (BookDbEntities entities = new BookDbEntities())
                {
                    return entities.Books.SingleOrDefault(book => book.Id == bookId);
                }
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }

        public void AddBook(string name)
        {
            using (BookDbEntities entities = new BookDbEntities())
            {
                Book book = new Book { BookName = name };
                entities.Books.Add(book);
                entities.SaveChanges();
            }
        }

        public void UpdateBook(string id, string name)
        {
            try
            {
                int bookId = Convert.ToInt32(id);

                using (BookDbEntities entities = new BookDbEntities())
                {
                    Book book = entities.Books.SingleOrDefault(b => b.Id == bookId);
                    book.BookName = name;
                    entities.SaveChanges();
                }
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }

        public void DeleteBook(string id)
        {
            try
            {
                int bookId = Convert.ToInt32(id);

                using (BookDbEntities entities = new BookDbEntities())
                {
                    Book book = entities.Books.SingleOrDefault(b => b.Id == bookId);
                    entities.Books.Remove(book);
                    entities.SaveChanges();
                }
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }
    }
}
