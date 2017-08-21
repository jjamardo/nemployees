using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class DeptEmpId
    {
        static Guid UUID = System.Guid.NewGuid();
        public virtual int EmpNo { get; set; }
        public virtual string DeptNo { get; set; }

        public override int GetHashCode()
        {
            return UUID.GetHashCode(); 
        }
        public override bool Equals(object obj)
        {
            DeptEmpId other = (DeptEmpId)obj;
            return other.DeptNo == DeptNo && other.EmpNo == EmpNo;
        }
    }
}
