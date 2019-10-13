using System;
using System.Diagnostics;

namespace TimeAndLogIt
{
    public class Timer : ITimer
    {
        Stopwatch timer;
        public TimeSpan GetResult()
        {
            return timer.Elapsed;
        }

        public void Start()
        {
            timer = Stopwatch.StartNew();
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
