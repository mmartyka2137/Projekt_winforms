using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_winforms
{
    public static class DateFormatter
    {
        public static string FormatDate(Date date, string format)
        {
            return date.Value.ToString(format);
        }

        // Dodatkowa metoda dla wygodnego formatowania do krótkiej postaci daty
        public static string ToShortDateString(Date date)
        {
            return date.Value.ToShortDateString();
        }
    }
}
