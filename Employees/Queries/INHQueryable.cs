using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Queries
{
    interface INHQueryable
    {
        void Query(ISession session, int limit);
    }
}