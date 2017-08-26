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
    class MaxSalaryPerEmployeeQuery : INHQueryable
    {
        public void Query(ISession session)
        {
            var c = session.CreateCriteria(typeof(Salary), "s");
            c.CreateAlias("s.Employee", "e");
            var co = Restrictions.Conjunction().Add(Restrictions.IsNotNull("SalaryId.EmpNo"));
            c.Add(co);
            ProjectionList proList = Projections.ProjectionList();
            proList.Add(Projections.Max("Zalary"));
            proList.Add(Projections.GroupProperty("SalaryId.EmpNo"));
            proList.Add(Projections.Property("e.FirstName"));
            proList.Add(Projections.Property("e.LastName"));
            c.Add(Restrictions.Le("Zalary", 80000));
            c.SetProjection(proList);
            c.SetMaxResults(100);
            var results = c.List();
            foreach (object[] result in results)
            {
                int salary = (int)result[0];
                int empNo = (int)result[1];
                string firstName = (string)result[2];
                string lastName = (string)result[3];
                Console.WriteLine("Employee: " + firstName + " " + lastName + " Salary: " + salary);
            }
        }
    }
}