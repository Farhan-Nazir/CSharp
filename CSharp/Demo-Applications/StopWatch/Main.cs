using System;
using System.Threading;
namespace CSharp.DemoApplications.StopWatch
{
    public class Main
    {
       public void StartTimer()
        {
            var stopWatch = new StopWatch();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Timer started now!!!");
                stopWatch.StartTimer();

                Thread.Sleep(3000);

                Console.WriteLine("Timer Ending now");
                stopWatch.EndTimer();

                Console.WriteLine("Duration: {0}", stopWatch.GetInterval());

                Console.WriteLine("Please press enter to start new timer.");
                Console.ReadLine();
            }
        }
    }
}
