using System;
namespace CSharp.Beginner
{
    public class AccEx
    {
        private double balance = 0;
        public void Deposit(int cash)
        {
            Console.WriteLine("Deposit Successful !!! {0}", cash);
            balance += cash;

        }
        public void WithDraw(int cash)
        {
            Console.WriteLine("Withdrawl Successful !!! {0}", cash);
            balance -= cash;
        }
        public double Balance()
        {
            return balance;
        }
    }
}
