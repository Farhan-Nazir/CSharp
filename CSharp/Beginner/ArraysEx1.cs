using System;
namespace CSharp.Beginner
{
    public class ArraysEx1
    {
        public void Ex1()
        {
            var friends = new string[3] { "Farhan", "Aamir", "Zahid" };
            var lastname = "Nazir";
            var result = string.Join(",", friends);
            Console.WriteLine(result, lastname);
        }
    }
}
