using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_winforms
{
    public class HolidayChecker
    {
        public bool IsHoliday(Date date)
        {
            // Przykład: Nowy Rok
            if (date.Value.Month == 1 && date.Value.Day == 1)
                return true;

            // Dodaj inne święta

            return false;
        }
    }
}
