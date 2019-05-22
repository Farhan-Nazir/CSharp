using System;
namespace CSharp.Intermediate
{
    public class Logger
    {
       public void Log(string message, DateTime startedAt)
        {
            Console.WriteLine(message,startedAt);
        }
    }
}
