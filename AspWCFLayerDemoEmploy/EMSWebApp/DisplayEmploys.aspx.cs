using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMS.BLL;
using EMS.DAL.EmployServiceReference;

namespace EMSWebApp
{
    public partial class DisplayEmploys : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                List<Employ> bList = EmployBLL.GetEmploysBLL();
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