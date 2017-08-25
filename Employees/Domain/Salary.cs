using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class Salary
    {
        public SalaryId SalaryId { get; set; }
        public Employee Employee { get; set; }
        public int Zalary { get; set; }
        public DateTime ToDate { get; set; }
    }
}
