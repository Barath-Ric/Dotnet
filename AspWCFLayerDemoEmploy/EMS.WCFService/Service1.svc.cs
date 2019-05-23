using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace EMS.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployService.svc or EmployService.svc.cs at the Solution Explorer and start debugging.
    public class EmployService : IEmployService
    {
        static string strcon = ConfigurationManager.ConnectionStrings["employconn"].ConnectionString;
        SqlConnection con = new SqlConnection(strcon);
        SqlCommand cmd;
        SqlDataReader dr;
        public string DeleteEmploy(int employid)
        {
            string procResult=string.Empty;
            try
            {
                con.Open();
                cmd = new SqlCommand("prcEmpDelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empno", employid);
                cmd.Parameters.Add(new SqlParameter("@result", SqlDbType.VarChar,30));
                cmd.Parameters["@result"].Direction = ParameterDirection.Output;                
                cmd.ExecuteNonQuery();
                procResult= Convert.ToString(cmd.Parameters["@result"].Value);                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return procResult;
        }

        public bool UpdateEmploy(Employ employ)
        {
            bool employupdated = false;
            try
            {
                cmd = new SqlCommand("prcEmpUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Empno", employ.Empno);
                cmd.Parameters.AddWithValue("@Nam", employ.Name);
                cmd.Parameters.AddWithValue("@Dept", employ.Department);
                cmd.Parameters.AddWithValue("@Desig", employ.Designation);
                cmd.Parameters.AddWithValue("@Basic", employ.Basic);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    employupdated = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return employupdated;
        }
        public bool AddEmploy(Employ employ)
        {
            bool employadded = false;
            try
            {
                cmd = new SqlCommand("prcEmpInsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empno", employ.Empno);
                cmd.Parameters.AddWithValue("@name", employ.Name);
                cmd.Parameters.AddWithValue("@dept", employ.Department);
                cmd.Parameters.AddWithValue("@desig", employ.Designation);
                cmd.Parameters.AddWithValue("@basic", employ.Basic);
                con.Open();
                cmd.ExecuteNonQuery();
                employadded = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
            return employadded;

        }
        public Employ SearchEmploy(int id)
        {
            Employ employ = null;
            try
            {
                cmd = new SqlCommand("prcEmpSearch", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@empno", id);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    employ = new Employ();
                    employ.Empno = Convert.ToInt32(dr["empno"]);
                    employ.Name = Convert.ToString(dr["nam"]);
                    employ.Department = Convert.ToString(dr["dept"]);
                    employ.Designation = Convert.ToString(dr["desig"]);
                    employ.Basic = Convert.ToInt32(dr["Basic"]);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dr.Close();
                con.Close();
            }
            return employ;
        }
        public List<Employ> ShowEmploy()
        {
            List<Employ> employList = null;
            try
            {
                cmd = new SqlCommand("PrcEmpShow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    employList = new List<Employ>();
                    while (dr.Read())
                    {
                        Employ e = new Employ();
                        e.Empno = Convert.ToInt32(dr["empno"]);
                        e.Name = Convert.ToString(dr["nam"]);
                        e.Department = Convert.ToString(dr["dept"]);
                        e.Designation = Convert.ToString(dr["desig"]);
                        e.Basic = Convert.ToInt32(dr["Basic"]);
                        employList.Add(e);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dr.Close();
                con.Close();
            }
            return employList;
        }

    }
}
