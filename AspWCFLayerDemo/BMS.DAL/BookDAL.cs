using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.DAL.BookServiceReference;

namespace BMS.DAL
{
    public class BookDAL
    {
        /* Right click on refrence and add service reference that is generated from the service and add exceptions dll
         Include the header "using BMS.DAL.BookServiceReference;" */

        BookServiceClient client = new BookServiceClient();
        public bool DeleteBookDAL(int bookID)
        {
            bool deletedbook = false;
            try
            {
                deletedbook = client.DeleteBook(bookID);
            }
            catch (Exception ex)
            {

                throw new BookExceptions.BookException(ex.Message);
            }
            return deletedbook;
        }
        public bool UpdateBookDAL(Book book)
        {
            bool updatedbook = false;
            try
            {
                updatedbook = client.UpdateBook(book);
            }
            catch (Exception ex)
            {

                throw new BookExceptions.BookException(ex.Message);
            }
            return updatedbook;
        }
        public bool AddBookDAL(Book book)
        {
            bool bookAdded = false;
            try
            {
                bookAdded = client.AddBook(book);
            }
            catch (Exception ex)
            {

                throw new BookExceptions.BookException(ex.Message);
            }
            return bookAdded;
        }
        public Book GetBookDAL(int id)
        {
            Book book = null;
            try
            {
                book = client.SearchBook(id);
            }
            catch (Exception ex)
            {

                throw new BookExceptions.BookException(ex.Message);
            }
            return book;
        }
        public List<Book> GetBooksDAL()
        {
            List<Book> bList = null;
            try
            {
                bList = client.ShowBook().ToList();
            }
            catch (Exception ex)
            {

                throw new BookExceptions.BookException(ex.Message);
            }
            return bList;
        }
    }
}
