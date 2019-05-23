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
    public partial class ViewBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                List<Book> bList = BookBLL.GetBooksBLL();
                GridView1.DataSource = bList.ToList();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {

                lblerror.Text = ex.Message;
            }
        }
    }
}