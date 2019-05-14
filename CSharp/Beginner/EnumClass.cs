using System;
namespace CSharp.Beginner
{
    public enum shippingMethod
    {
        RegularMail = 1,
        ExpressMail = 2,

    }
    public class EnumClass
    {
        public void SelectedMethod()
        {
            var regularMethod = shippingMethod.RegularMail;
            Console.WriteLine((int)regularMethod);
        }
        public int GetShippingMethod(string method)
        {
            if(method == "RegularMail")
            {
                return (int)shippingMethod.RegularMail;
            } else if(method == "ExpressMail")
            {
                return (int)shippingMethod.ExpressMail;
            }
            return 0;
        }
    }
}
