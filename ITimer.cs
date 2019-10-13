using System;

namespace TimeAndLogIt
{
    public interface ITimer
    {
        void Start();
        void Stop();
        TimeSpan GetResult();
    }
}
