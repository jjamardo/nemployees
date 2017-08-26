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
    class EngineersResearchersQuery : INHQueryable
    {
        public void Query(ISession session)
        {
            /* Prints all employees that are from Research department and are Engineers */
            /* Using projections instead of create Employee objects */
            var c = session.CreateCriteria(typeof(Employee), "employee");
            c.CreateAlias("employee.DeptEmps", "deptEmps");
            c.CreateAlias("deptEmps.Department", "department");
            c.Add(Restrictions.Eq("department.DeptName", "Research"));
            var co = Restrictions.Conjunction().Add(Restrictions.Eq("TitleId.Title", "Engineer"));
            c.CreateCriteria("Titles").Add(co);
            ProjectionList proList = Projections.ProjectionList();
            proList.Add(Projections.Property("employee.FirstName"));
            proList.Add(Projections.Property("employee.LastName"));
            c.SetProjection(proList);
            var results = c.List();
            foreach (Object[] result in results)
            {
                string firstName = (string)result[0];
                string lastName = (string)result[1];
                Console.WriteLine("Name: " + firstName + " " + lastName);
            }
        }
    }
}