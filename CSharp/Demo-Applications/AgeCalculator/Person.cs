using System;
namespace CSharp.DemoApplications.AgeCalculator
{
    public class Person
    {
       
        public DateTime Birthday
        {
            get;
            private set;
        }
        public Person(DateTime birthday)
        {
            this.Birthday = birthday;
        }

        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthday;
                var calculateAge = timespan.Days / 365;
                return calculateAge;
            }
        }
    }
}
