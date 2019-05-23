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
    public partial class SearchEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmpno.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "m2", "alert('Please enter id to search')", true);
            }
            else
            {
                try
                {
                    int searchid = Convert.ToInt32(txtEmpno.Text);
                    Employ employ = EmployBLL.GetEmployBLL(searchid);
                    if (employ != null)
                    {
                        txtname.Text = employ.Name;
                        txtDept.Text = employ.Department;
                        txtDesig.Text = employ.Designation;
                        txtbasic.Text = employ.Basic.ToString();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m4", "alert('Employ not available')", true);
                    }
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "error1", "alert('" + ex.Message + "')", true);
                }
            }
        }
    }
}