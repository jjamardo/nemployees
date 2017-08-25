using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class Employee
    {
        public virtual int EmpNo { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Gender { get; set; }
        public virtual DateTime BirthDate { get; set; }
        public virtual DateTime HireDate { get; set; }
        public virtual ISet<DeptEmp> DeptEmps { get; set; }
        public virtual ISet<DeptManager> DeptManagers { get; set; }
        public virtual ISet<Salary> Salaries { get; set; }
        public virtual ISet<Title> Titles { get; set; }
    }
}
