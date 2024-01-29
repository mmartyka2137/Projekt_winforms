using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_winforms
{
    public class DateCalculator
    {
        public static int DifferenceInDays(Date date1, Date date2)
        {
            TimeSpan difference = date1.Value - date2.Value;
            return Math.Abs(difference.Days);
        }
    }
}
