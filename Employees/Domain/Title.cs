using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class Title
    {
        public TitleId TitleId { get; set; }
        public Employee Employee { get; set; }
        public DateTime ToDate { get; set; }
    }
}
