using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.DAL.EmployServiceReference;

namespace EMS.DAL
{
    public class EmployDAL
    {
        EmployServiceClient client = new EmployServiceClient();
        public string DeleteEmployDAL(int employID)
        {
            string deletedbook = string.Empty;
            try
            {
                deletedbook = client.DeleteEmploy(employID);
            }
            catch (Exception ex)
            {

                throw new EmployExceptions.EmployException(ex.Message);
            }
            return deletedbook;
        }
        public bool UpdateEmployDAL(Employ employ)
        {
            bool updatedemploy = false;
            try
            {
                updatedemploy = client.UpdateEmploy(employ);
            }
            catch (Exception ex)
            {

                throw new EmployExceptions.EmployException(ex.Message);
            }
            return updatedemploy;
        }
        public bool AddEmployDAL(Employ employ)
        {
            bool employAdded = false;
            try
            {
                employAdded = client.AddEmploy(employ);
            }
            catch (Exception ex)
            {

                throw new EmployExceptions.EmployException(ex.Message);
            }
            return employAdded;
        }
        public Employ GetEmployDAL(int id)
        {
            Employ employ = null;
            try
            {
                employ = client.SearchEmploy(id);
            }
            catch (Exception ex)
            {

                throw new EmployExceptions.EmployException(ex.Message);
            }
            return employ;
        }
        public List<Employ> GetEmploysDAL()
        {
            List<Employ> eList = null;
            try
            {
                eList = client.ShowEmploy().ToList();
            }
            catch (Exception ex)
            {

                throw new EmployExceptions.EmployException(ex.Message);
            }
            return eList;
        }
    }
}
