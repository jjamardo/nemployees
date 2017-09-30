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
            //var query1 = new ManagersQuery();
            //TranasactionalQuery(query1);

            var query2 = new EngineersHiredBefore1990();
            TranasactionalQuery(query2, int.Parse(args[0]));

            //var query3 = new ResearchersWhoEarnLessThanQuery();
            //TranasactionalQuery(query3);

            //var query4 = new ListEmployeesQuery();
            //TranasactionalQuery(query4);
        }

        private static void TranasactionalQuery(INHQueryable query, int limit)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    query.Query(session, limit);
                }
            }
        }
    }
}
