using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EMS.WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployService" in both code and config file together.
    [ServiceContract]
    public interface IEmployService
    {
        [OperationContract]
        Employ SearchEmploy(int id);
        [OperationContract]
        List<Employ> ShowEmploy();
        [OperationContract]
        bool AddEmploy(Employ employ);
        [OperationContract]
        bool UpdateEmploy(Employ employ);
        [OperationContract]
        string DeleteEmploy(int employid);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Employ
    {
        [DataMember]
        public int Empno { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Department { get; set; }
        [DataMember]
        public string Designation { get; set; }
        [DataMember]
        public int Basic { get; set; }
    }
}
