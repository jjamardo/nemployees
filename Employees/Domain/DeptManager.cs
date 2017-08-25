using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    class DeptManager
    {
        private DeptManagerId DeptManagerId { get; set; }
        private Employee Employee { get; set; }
        private Department Department { get; set; }
        private DateTime FromDate { get; set; }
        private DateTime ToDate { get; set; }
    }
}
