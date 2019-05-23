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
    public partial class UpdateBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtBookID.Text==string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "m2", "alert('Please enter id to search')", true);
            }
            else
            {
                try
                {
                    int searchid = Convert.ToInt32(txtBookID.Text);
                    Book book = BookBLL.GetBookBLL(searchid);
                    if (book != null)
                    {
                        txtName.Text = book.Name;
                        txtPrice.Text = book.Price.ToString();
                        txtDesciption.Text = book.Description;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m4", "alert('Book not available')", true);
                    }
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "error1", "alert('"+ex.Message+"')", true);
                }
            }
        }

        protected void btnUpdateBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            try
            {
                book.ID = Convert.ToInt32(txtBookID.Text);
                book.Name = txtName.Text;
                book.Price = Convert.ToDecimal(txtPrice.Text);
                book.Description = txtDesciption.Text;
                bool status = BookBLL.UpdateBookBLL(book);
                if (status)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "M1", "alert('Book Details Updated')", true);
                    txtBookID.Text = "";
                    txtName.Text = "";
                    txtDesciption.Text = "";
                    txtPrice.Text = "";
                }
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "error1", "alert('" + ex.Message + "')", true);
            }
        }
    }
}