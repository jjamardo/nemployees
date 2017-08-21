using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class Department
    {
        private string deptNo;

        public virtual string DeptNo
        {
            get { return deptNo; }
            set { deptNo = value; }
        }

        private string deptName;

        public virtual string DeptName
        {
            get { return deptName; }
            set { deptName = value; }
        }

        public override bool Equals(object obj)
        {
            Department other = (Department)obj;
            return other.DeptNo.Equals(DeptNo);
        }

        public override int GetHashCode()
        {
            return DeptNo.GetHashCode();
        }
        public virtual List<DeptEmp> DeptEmps { get; set; }
    }
}
