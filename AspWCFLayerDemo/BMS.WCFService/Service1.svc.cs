using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace BMS.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookService.svc or BookService.svc.cs at the Solution Explorer and start debugging.
    
    public class BookService : IBookService
    {
        static string strcon = ConfigurationManager.ConnectionStrings["bookconn"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd;
        SqlDataReader dr;
        public bool DeleteBook(int bookid)
        {
            bool bookdeleted = false;
            try
            {
                cmd = new SqlCommand("usp_DeleteBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", bookid);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    bookdeleted = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return bookdeleted;
        }

        public bool UpdateBook(Book book)
        {
            bool bookupdated = false;
            try
            {
                cmd = new SqlCommand("usp_UpdateBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", book.ID);
                cmd.Parameters.AddWithValue("@name", book.Name);
                cmd.Parameters.AddWithValue("@price", book.Price);
                cmd.Parameters.AddWithValue("@desc", book.Description);
                con.Open();
                int result=cmd.ExecuteNonQuery();
                if (result>0)
                {
                    bookupdated = true;
                }                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return bookupdated;
        }
        public bool AddBook(Book book)
        {
            bool bookadded = false;
            try
            {
                cmd = new SqlCommand("usp_InsertBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", book.ID);
                cmd.Parameters.AddWithValue("@name", book.Name);
                cmd.Parameters.AddWithValue("@price", book.Price);
                cmd.Parameters.AddWithValue("@desc", book.Description);
                con.Open();
                cmd.ExecuteNonQuery();
                bookadded = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return bookadded;           

        }
        public Book SearchBook(int id)
        {
            Book book = null;
            try
            {
                cmd = new SqlCommand("usp_SearchBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    book = new Book();
                    book.ID = dr.GetInt32(0);
                    book.Name = dr.GetString(1);
                    book.Price = dr.GetDecimal(2);
                    book.Description = dr.GetString(3);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dr.Close();
                con.Close();
            }
            return book;
        }
       public List<Book> ShowBook()
        {
            List<Book> bookList = null;
            try
            {
                cmd = new SqlCommand("usp_ShowBook", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    bookList = new List<Book>();
                    while (dr.Read())
                    {
                        Book b = new Book();
                        b.ID = dr.GetInt32(0);
                        b.Name = dr.GetString(1).ToString();
                        b.Price = dr.GetDecimal(2);
                        b.Description = dr.GetString(3).ToString();
                        bookList.Add(b);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dr.Close();
                con.Close();
            }
            return bookList;
        }
    }
    
}
