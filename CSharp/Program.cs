using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Beginner.ArraysEx1 ex1 = new Beginner.ArraysEx1();
            //ex1.Ex1();
            //ex1.JaggedArray();
            //Beginner.EnumClass ex2 = new Beginner.EnumClass();
            //ex2.SelectedMethod();
            //var shippingId = new Beginner.EnumClass();
            //Console.WriteLine(shippingId.GetShippingMethod("RegularMail"));
            // var accBalance = new Beginner.AccEx();
            // accBalance.Deposit(500 *2);
            // Console.WriteLine("Balance {0}",accBalance.Balance());
            // accBalance.WithDraw(200);
            // Console.WriteLine("Balance {0}", accBalance.Balance());

            // var loops = new Beginner.Loops();
            // loops.GenerateEvenNumbers();
            // Console.WriteLine(loops.NameLength("Farhan")); ;
            // loops.NameWords("Farhan");

            // var listEx = new Beginner.Lists();
            // listEx.ListsArrays();

            // var dateTime = new Beginner.TimeDate();
            // dateTime.CurrentDateTime();
            // dateTime.TimeSpanEx();
            //var farhanAge =  dateTime.AgeCalculator(1984);
            // Console.WriteLine("Farhan is {0} years old", farhanAge);
            // 

            //var atmSystem = new Demo_Applications.ATM_Machine.Main();
            //atmSystem.Start();
            //var ageCalculator = new DemoApplications.AgeCalculator.Main();
            //ageCalculator.StartProgram();
            var webIntegration = new Intermediate.WebIntegration(new Intermediate.Logger(), new Intermediate.SuccessMessage());
            webIntegration.StartIntegration();
            var dependenciesInstaller = new Intermediate.DependenciesInstaller(new Intermediate.Logger());
            dependenciesInstaller.DependenciesInstallerStarted();
            Console.ReadLine();
        }
    }
}
