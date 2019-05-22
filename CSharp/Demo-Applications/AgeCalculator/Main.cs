using System;
namespace CSharp.DemoApplications.AgeCalculator
{
    public class Main
    {
       public void StartProgram()
        {
            var farhan = new Person(new DateTime(1984, 11, 13));
            Console.WriteLine("Farhan is {0} years old.", farhan.Age);
        }

    }
}
