using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_winforms
{
    public class DateChanger
    {
        public Date AddDays(Date date, int days)
        {
            DateTime newDateTime = date.Value.AddDays(days);
            return new Date(newDateTime.Year, newDateTime.Month, newDateTime.Day);
        }

        public Date AddMonths(Date date, int months)
        {
            DateTime newDateTime = date.Value.AddMonths(months);
            return new Date(newDateTime.Year, newDateTime.Month, newDateTime.Day);
        }
    }
}
