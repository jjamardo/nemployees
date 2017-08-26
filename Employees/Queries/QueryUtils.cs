using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Queries
{
    class QueryUtils
    {
        public static DateTime ToThePresent()
        {
            var format = "yyyy-mm-dd";
            var present = "9999-01-01";
            var culture = CultureInfo.InvariantCulture;
            return DateTime.ParseExact(present, format, culture);
        }
    }
}
