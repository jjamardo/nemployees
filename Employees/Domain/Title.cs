using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class Title
    {
        public virtual TitleId TitleId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual DateTime ToDate { get; set; }
    }
}
