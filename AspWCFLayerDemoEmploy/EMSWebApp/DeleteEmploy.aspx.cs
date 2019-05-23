using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMS.DAL.EmployServiceReference;
using EMS.BLL;


namespace EMSWebApp
{
    public partial class DeleteEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtEmpno.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "m2", "alert('Please enter id to Delete')", true);
            }
            else
            {
                try
                {
                    int deleteId = Convert.ToInt32(txtEmpno.Text);
                    string status = EmployBLL.DeleteEmployBLL(deleteId);
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "m3", "alert('"+ status+"')", true);
                   
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "error", "alert('" + ex.Message + "')", true);
                }
            }
        }
    }
}