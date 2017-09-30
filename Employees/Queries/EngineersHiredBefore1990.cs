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
    class EngineersHiredBefore1990 : INHQueryable
    {
        public void Query(ISession session, int limit)
        {
            /** Prints all employees that are from Research department and are Engineers */
            /* Using projections instead of create Employee objects */
            var c = session.CreateCriteria(typeof(Employee), "employee");
            c.CreateAlias("employee.DeptEmps", "deptEmps");
            c.CreateAlias("deptEmps.Department", "department");
            var co = Restrictions.Conjunction()
                    .Add(Restrictions.Eq("TitleId.Title", "Engineer"));
            c.CreateCriteria("Titles").Add(co);
            ProjectionList proList = Projections.ProjectionList();
            proList.Add(Projections.Property("employee.FirstName"));
            proList.Add(Projections.Property("employee.LastName"));
            proList.Add(Projections.Property("employee.HireDate"));
            proList.Add(Projections.Property("department.DeptName"));
            c.Add(Restrictions.Le("employee.HireDate", QueryUtils.DateParse("1990-01-01")));
            c.SetProjection(proList);
            c.SetMaxResults(limit);
            var results = c.List();
            foreach (object[] result in results)
            {
                string firstName = (string)result[0];
                string lastName = (string)result[1];
                DateTime hireDate = (DateTime)result[2];
                string deptName = (string)result[3];
                Console.WriteLine("Name: " + firstName + " " + lastName + ", Department: " + deptName + ", Hire: " + hireDate);
            }
            Console.WriteLine("Results size: " + results.Count);
        }
    }
}