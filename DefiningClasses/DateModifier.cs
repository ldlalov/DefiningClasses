using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public static class DateModifier
    {
        public static void CalculateDates(DateTime startDate, DateTime endDate)
        {
            TimeSpan days = endDate - startDate;
            Console.WriteLine(Math.Abs(days.Days));
        }
    }
}
