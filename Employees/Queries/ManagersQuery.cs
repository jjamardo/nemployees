using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Criterion;
using Employees.Domain;

namespace Employees.Queries
{
    class ManagersQuery : INHQueryable
    {
	    public void Query(ISession session)
        {
		    /* Prints all active managers (limited) */
		    var c = session.CreateCriteria(typeof(DeptManager));
		    c.Add(Restrictions.Eq("ToDate", QueryUtils.ToThePresent()));
            c.SetMaxResults(1);
		    var results = c.List();
            foreach (DeptManager manager in results)
            {
			    string name = manager.Employee.FirstName + " " + manager.Employee.LastName;
			    string department = manager.Department.DeptName;
                Console.WriteLine("Department: " + department + ", Manager: " + name + ", From: " + manager.FromDate);
            }
        }
    }
}
