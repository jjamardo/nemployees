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
        public virtual List<DeptEmp> DeptEmps { get; set; }
    }
}
