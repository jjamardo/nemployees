using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class Department
    {
        public virtual string DeptNo { get; set;}
        public virtual string DeptName { get; set; }
        public virtual ISet<DeptEmp> DeptEmps { get; set; }
        public virtual ISet<DeptManager> DeptManagers { get; set; }
    }
}
