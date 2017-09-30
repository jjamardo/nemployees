using Employees.Domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Queries
{
    class ListEmployeesQuery : INHQueryable
    {
        public void Query(ISession session, int limit)
        {
            var c = session.CreateCriteria(typeof(Employee));
            c.SetMaxResults(limit);
            var results = c.List();
            for (int i = 0; i < results.Count; i++)
            {
                Employee employee = (Employee)results[i];
                Console.WriteLine("Employee: " + employee.FirstName + " " + employee.LastName);
            }
        }
    }
}
