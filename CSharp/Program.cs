using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Beginner.ArraysEx1 ex1 = new Beginner.ArraysEx1();
            ex1.Ex1();
            Beginner.EnumClass ex2 = new Beginner.EnumClass();
            ex2.SelectedMethod();
            var shippingId = new Beginner.EnumClass();
            Console.WriteLine(shippingId.GetShippingMethod("TestMail"));

            Console.ReadLine();
        }
    }
}
