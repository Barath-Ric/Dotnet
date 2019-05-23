using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.DAL.EmployServiceReference;
using EMS.DAL;
using EMS.EmployExceptions;

namespace EMS.BLL
{
    public class EmployBLL
    {
        public static bool ValidateEmploy(Employ employ)
        {
            bool result = true;
            StringBuilder sb = new StringBuilder();

            if (employ.Empno <= 0 || employ.Empno == null)
            {
                result = false;
                sb.Append("Empno cannot be blank or negative");
            }

            if (employ.Name == string.Empty)
            {
                result = false;
                sb.Append("Employ Name cannot be blank");
            }

            if (employ.Department == string.Empty)
            {
                result = false;
                sb.Append("Department cannot be blank");
            }
            if (employ.Designation == string.Empty)
            {
                result = false;
                sb.Append("Designation cannot be blank");
            }

            if (result == false)
            {
                throw new EmployExceptions.EmployException(sb.ToString());
            }
            return result;
        }
        public static string DeleteEmployBLL(int id)
        {
            string employdelete = string.Empty;

            try
            {
                if (id > 0)
                {
                    EmployDAL emsdal = new EmployDAL();
                    employdelete = emsdal.DeleteEmployDAL(id);
                }
                else
                {
                    throw new EmployExceptions.EmployException("Invalid Employ ID");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return employdelete;
        }
        public static bool UpdateEmployBLL(Employ employ)
        {
            bool employupdated = false;
            try
            {
                if (ValidateEmploy(employ))
                {
                    EmployDAL emsdal = new EmployDAL();
                    employupdated = emsdal.UpdateEmployDAL(employ);

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return employupdated;
        }
        public static bool AddEmployBLL(Employ employ)
        {
            bool employadded = false;
            try
            {
                if (ValidateEmploy(employ))
                {
                    EmployDAL obj = new EmployDAL();
                    employadded = obj.AddEmployDAL(employ);
                }
            }
            catch (Exception ex)
            {

                throw new EmployExceptions.EmployException(ex.Message);
            }
            return employadded;
        }
        public static Employ GetEmployBLL(int employid)
        {
            Employ employ = null;
            try
            {
                EmployDAL bmsdal = new EmployDAL();
                employ = bmsdal.GetEmployDAL(employid);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return employ;
        }

        public static List<Employ> GetEmploysBLL()
        {
            List<Employ> employList = null;
            try
            {
                EmployDAL emsdal = new EmployDAL();
                employList = emsdal.GetEmploysDAL();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return employList;
        }

    }
}
