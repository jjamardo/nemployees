using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class DeptManager
    {
        public virtual DeptManagerId DeptManagerId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Department Department { get; set; }
        public virtual DateTime FromDate { get; set; }
        public virtual DateTime ToDate { get; set; }
    }
}
