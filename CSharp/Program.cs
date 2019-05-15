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
            //var shippingId = new Beginner.EnumClass();
            //Console.WriteLine(shippingId.GetShippingMethod("RegularMail"));
            var accBalance = new Beginner.AccEx();
            accBalance.Deposit(500 *2);
            Console.WriteLine("Balance {0}",accBalance.Balance());
            accBalance.WithDraw(200);
            Console.WriteLine("Balance {0}", accBalance.Balance());

            var loops = new Beginner.Loops();
            loops.GenerateEvenNumbers();
            Console.WriteLine(loops.NameLength("Farhan")); ;
            loops.NameWords("Farhan");

            Console.ReadLine();
        }
    }
}
