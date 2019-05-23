using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMSWebApp
{
    public partial class BookManagementSystem : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkAddBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }

        protected void lnkUpdateBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateBook.aspx");
        }

        protected void lnkDeleteBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteBook.aspx");
        }

        protected void lnkSearchBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchBook.aspx");
        }

        protected void lnkDisplayBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBooks.aspx");
        }
    }
}