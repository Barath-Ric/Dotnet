using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BMS.BLL;
using BMS.DAL.BookServiceReference;

namespace BMSWebApp
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            try
            {
                book.ID = Convert.ToInt32(txtBookID.Text);
                book.Name = txtName.Text;
                book.Price = Convert.ToDecimal(txtPrice.Text);
                book.Description = txtDesciption.Text;
                bool status = BookBLL.AddBookBLL(book);
                if (status)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "M1", "alert('Book Details Added')", true);
                    txtBookID.Text = "";
                    txtName.Text = "";
                    txtDesciption.Text = "";
                    txtPrice.Text = "";
                }
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "M1", "alert('"+ex.Message+"')", true);
            }
        }
    }
}