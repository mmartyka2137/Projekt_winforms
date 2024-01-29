using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_winforms
{
    public class Date
    {
        public DateTime Value { get; private set; }

        public Date(int year, int month, int day)
        {
            Value = new DateTime(year, month, day);
        }

        public static TimeSpan Difference(Date date1, Date date2)
        {
            return date1.Value - date2.Value;
        }

        public override string ToString()
        {
            return Value.ToShortDateString();
        }
    }
}
