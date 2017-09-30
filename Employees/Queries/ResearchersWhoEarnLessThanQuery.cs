using Employees.Domain;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Queries
{
    class ResearchersWhoEarnLessThanQuery : INHQueryable
    {
        public void Query(ISession session, int limit)
        {
            var c = session.CreateCriteria(typeof(Salary), "s");
            c.CreateAlias("s.Employee", "e");
		    c.CreateAlias("e.DeptEmps", "de");
		    c.CreateAlias("de.Department", "dp");
            var co = Restrictions.Conjunction().Add(Restrictions.IsNotNull("SalaryId.EmpNo"));
            c.Add(co);
            ProjectionList proList = Projections.ProjectionList();
            proList.Add(Projections.Max("Zalary"));
            proList.Add(Projections.GroupProperty("SalaryId.EmpNo"));
            proList.Add(Projections.Property("e.FirstName"));
            proList.Add(Projections.Property("e.LastName"));
            c.Add(Restrictions.Le("Zalary", 70000));
            c.Add(Restrictions.Eq("dp.DeptName", "Research"));
            c.SetProjection(proList);
            //c.SetMaxResults(limit);
            var results = c.List();
            foreach (object[] result in results)
            {
                int salary = (int)result[0];
                string firstName = (string)result[2];
                string lastName = (string)result[3];
                Console.WriteLine("Employee: " + firstName + " " + lastName + " Salary: " + salary);
            }
            Console.WriteLine("Results size: " + results.Count);
        }
    }
}