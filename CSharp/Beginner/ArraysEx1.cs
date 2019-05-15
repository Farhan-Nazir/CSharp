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

        public void JaggedArray()
        {
            var families = new string[3][];
            families[0] = new string[] { "Farhan", "Inaaya", "Bilal" };
            families[1] = new string[] { "Aamir", "Iman", "Laiba" };
            families[2] = new string[] { "Rauf", "Zahid", "Jamil" };
            foreach (var family in families)
            {
                Console.WriteLine("Families Jagged Arrays\n" + string.Join("\n", family));
            }



        }
    }
}
