using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Employees.Domain;
using Employees.Repositories;
using NHibernate;
using NHibernate.Criterion;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
            	{
                    var criteria = session.CreateCriteria(typeof(Employee), "employee");
                    criteria.CreateAlias("employee.DeptEmps", "deptEmps");
                    criteria.CreateAlias("deptEmps.Department", "department");
            	    criteria.Add(Restrictions.Eq("department.DeptName", "Sales"));
                    var proList = Projections.ProjectionList();
                    proList.Add(Projections.Property("employee.FirstName"));
                    proList.Add(Projections.Property("employee.LastName"));
                    proList.Add(Projections.Property("department.DeptName"));
                    criteria.SetProjection(proList);
                    var results = criteria.List();
                    foreach (var res in results)
                    {
                        object[] result = (object[])res;
                        string firstName = (string)result[0];
                        string lastName = (string)result[1];
                        string deptName = (string)result[2];
                        Console.WriteLine("Name: " + firstName + " " + lastName + " DeptName: " + deptName);
                    }
            	}
        }
    }
}
