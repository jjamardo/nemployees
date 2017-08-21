using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class DeptEmp
    {
        static Guid UUID = System.Guid.NewGuid();

        public virtual DeptEmpId Id { get; set; }

        private Department department;

        public virtual Department Department
        {
            get { return department; }
            set { department = value; }
        }

        private Employee employee;

        public virtual Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }

        public override bool Equals(object obj)
        {
            DeptEmp other = (DeptEmp)obj;
            return other.Department.Equals(Department) && other.Employee.Equals(Employee);
        }

        public override int GetHashCode()
        {
            return UUID.GetHashCode();
        }
    }
}
