using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class SalaryId
    {
        public int EmpNo { get; set; }
        public DateTime FromDate { get; set; }

        public override int GetHashCode()
        {
            return (EmpNo + "|" + FromDate).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            SalaryId other = (SalaryId)obj;
            return EmpNo == other.EmpNo && FromDate == other.FromDate;
        }
    }
}
