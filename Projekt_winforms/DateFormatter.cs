using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_winforms
{
    public class DateFormatter
    {
        public string FormatDate(Date date, string format)
        {
            return date.Value.ToString(format);
        }

        // Dodatkowa metoda dla wygodnego formatowania do krótkiej postaci daty
        public string ToShortDateString(Date date)
        {
            return date.Value.ToShortDateString();
        }
    }
}
