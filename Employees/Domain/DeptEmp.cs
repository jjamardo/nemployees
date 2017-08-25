using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class DeptEmp
    {
        public virtual DeptEmpId DeptEmpId { get; set; }
        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
