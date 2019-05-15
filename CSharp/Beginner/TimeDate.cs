using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Beginner
{
    class TimeDate
    {
        public void CurrentDateTime()
        {
            var currentDateTime = DateTime.Now;
            Console.WriteLine(currentDateTime);
        }

        public void TimeSpanEx()
        {
            var timeSpan = new TimeSpan(1, 2, 4);
            Console.WriteLine(timeSpan);
        }
        public int AgeCalculator(int year)
        {
          var currentDate = DateTime.Now;
            var currentYear = currentDate.Year;
           
            var cal = Convert.ToInt32(currentYear) - year;
            return cal;

        }
    }
}
