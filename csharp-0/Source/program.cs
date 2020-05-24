using Codenation.Challenge;
using System;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace Source
{
    public class program
    {
        static void Main (string[] args){
            Codenation.Challenge.Math math = new Codenation.Challenge.Math();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 100; i++)
            {
                int n = math.DynamicFibonacci(i);
                bool r = math.IsFibonacci(n);
                if (r)
                    Console.Write(n+" ");
            }
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}