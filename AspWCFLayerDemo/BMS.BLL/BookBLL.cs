using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.DAL.BookServiceReference;
using BMS.DAL;
using BMS.BookExceptions;

namespace BMS.BLL
{
    public class BookBLL
    {
        public static bool ValidateBook(Book book)
        {
            bool result = true;
            StringBuilder sb = new StringBuilder();

            if (book.ID <= 0 || book.ID == null)
            {
                result = false;
                sb.Append("ID cannot be blank or negative");
            }

            if (book.Name == string.Empty)
            {
                result = false;
                sb.Append("Book Name cannot be blank");
            }

            if (book.Description == string.Empty)
            {
                result = false;
                sb.Append("Description cannot be blank");
            }
            if (book.Price <= 0 || book.Price == null)
            {
                result = false;
                sb.Append("Price cannot be negative or zero");
            }

            if (result == false)
            {
                throw new BookExceptions.BookException(sb.ToString());
            }
            return result;
        }
        public static bool DeleteBookBLL(int id)
        {
            bool bookdelete = false;

            try
            {
                if (id > 0)
                {
                    BookDAL bmsdal = new BookDAL();
                    bookdelete = bmsdal.DeleteBookDAL(id);
                }
                else
                {
                    throw new BookExceptions.BookException("Invalid Book ID");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bookdelete;
        }
        public static bool UpdateBookBLL(Book book)
        {
            bool bookupdated = false;
            try
            {
                if (ValidateBook(book))
                {
                    BookDAL bmsdal = new BookDAL();
                    bookupdated = bmsdal.UpdateBookDAL(book);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return bookupdated;
        }
        public static bool AddBookBLL(Book book)
        {
            bool bookadded = false;
            try
            {
                if (ValidateBook(book))
                {
                    BookDAL obj = new BookDAL();
                    bookadded = obj.AddBookDAL(book);
                }
            }
            catch (Exception ex)
            {

                throw new BookExceptions.BookException(ex.Message);
            }
            return bookadded;
        }
        public static Book GetBookBLL(int bookid)
        {
            Book book = null;
            try
            {
                BookDAL bmsdal = new BookDAL();
                book = bmsdal.GetBookDAL(bookid);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return book;
        }

        public static List<Book> GetBooksBLL()
        {
            List<Book> bookList = null;
            try
            {
                BookDAL bmsdal = new BookDAL();
                bookList = bmsdal.GetBooksDAL();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return bookList;
        }
        
    }
}
