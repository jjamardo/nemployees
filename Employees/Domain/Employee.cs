using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class Employee
    {
        private int empNo;

        public virtual int EmpNo
        {
            get { return empNo; }
            set { empNo = value; }
        }

        private string firstName;

        public virtual string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public virtual string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string gender;

        public virtual string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private DateTime birthDate;

        public virtual DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        private DateTime hireDate;

        public virtual DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public override bool Equals(object obj)
        {
            Employee other = (Employee)obj;
            return other.EmpNo.Equals(EmpNo);
        }

        public override int GetHashCode()
        {
            return EmpNo.GetHashCode();
        }

        public virtual List<DeptEmp> DeptEmps { get; set; }
    }
}
