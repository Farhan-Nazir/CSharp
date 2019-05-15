using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Beginner
{
    class Lists
    {
        public void ListsArrays()
        {
            var evenNumberList = new List<int>(); // Dynamic List
            for (int i = 0; i < 15; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumberList.Add(i);
                }                
            }
            foreach (var item in evenNumberList)

            {
                Console.WriteLine("{0} is even number", item);
            }
        }
    }
}
