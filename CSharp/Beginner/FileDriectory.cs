using System;
using System.IO;

namespace CSharp.Beginner
{
    class FileDriectory
    {
        public void FileDirectoryEx()
        {
            Directory.CreateDirectory(@"C:\Users\farhannr\Documents\CSharp\CSharp\Intermediate");
            Console.WriteLine("Directory Created !!!");
            File.Create(@"C:\Users\farhannr\Documents\CSharp\CSharp\Intermediate\data.txt");
            Console.WriteLine("File Created !!!");
        }
    }
}
