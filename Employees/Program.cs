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
using Employees.Queries;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            var query1 = new ManagersQuery();
            TranasactionalQuery(query1);

            //var query2 = new EngineersResearchersQuery();
            //TranasactionalQuery(query2);

            //var query3 = new MaxSalaryPerEmployeeQuery();
            //TranasactionalQuery(query3);
        }

        private static void TranasactionalQuery(INHQueryable query)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    query.Query(session);
                }
            }
        }
    }
}
