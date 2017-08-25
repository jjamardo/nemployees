using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class TitleId
    {
        public virtual int EmpNo { get; set; }
        public virtual string Title { get; set; }
        public virtual DateTime FromDate { get; set; }

        public override int GetHashCode()
        {
            return (EmpNo + "|" + Title + "|" + FromDate).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            TitleId other = (TitleId)obj;
            return EmpNo == other.EmpNo && Title == other.Title && FromDate == other.FromDate;
        }
    }
}
