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
    public partial class AddEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Employ employ = new Employ();
            try
            {
                employ.Empno = Convert.ToInt32(txtEmpno.Text);
                employ.Name = txtname.Text;
                employ.Department = txtDept.Text;
                employ.Designation = txtDesig.Text;
                employ.Basic = Convert.ToInt32(txtbasic.Text);
                bool status = EmployBLL.AddEmployBLL(employ);
                if (status)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "M1", "alert('Employ Details Added')", true);
                    txtEmpno.Text = "";
                    txtname.Text = "";
                    txtDept.Text = "";
                    txtDesig.Text = "";
                    txtbasic.Text = "";
                }
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "M1", "alert('" + ex.Message + "')", true);
            }
        }
    }
}