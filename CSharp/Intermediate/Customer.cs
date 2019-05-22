using System;
namespace CSharp.Intermediate
{
    public class Customer
    {
        public Customer(DateTime customerBirthday)
        {
            this.CustomerBirthday = customerBirthday;

        }
        public DateTime CustomerBirthday { get; private set; }
        public int CustomerAge
        {
            get
            {
                var timespan = DateTime.Today - CustomerBirthday;
                var age = timespan.Days/ 365;
                return age;
            }
        }
    }
}
