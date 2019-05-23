using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.EmployExceptions
{
    public class EmployException:ApplicationException
    {
        public EmployException()
        { }
        public EmployException(string message) : base(message)
        { }
    }
}
