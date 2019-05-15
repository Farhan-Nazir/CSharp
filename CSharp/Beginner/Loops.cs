using System;
namespace CSharp.Beginner
{
    public class Loops
    {
        public void GenerateEvenNumbers()
        {
            for (int i = 0; i < 100; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine("Even number {0}", i);
                }
            }
        }

        public int NameLength(string name)
        {
            return name.Length;
        }

        public void NameWords(string name)
        {
           
            foreach (var word in name)
            {
                Console.WriteLine("{0}",word);
            }
        }

    }
}
