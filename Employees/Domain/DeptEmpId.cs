﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain
{
    public class DeptEmpId
    {
        public virtual int EmpNo { get; set; }
        public virtual string DeptNo { get; set; }

        public override int GetHashCode()
        {
            return (EmpNo + "|" + DeptNo).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            DeptEmpId other = (DeptEmpId)obj;
            return other.DeptNo == DeptNo && other.EmpNo == EmpNo;
        }
    }
}
