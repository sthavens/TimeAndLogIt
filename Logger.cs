using System;

namespace TimeAndLogIt
{
    public class Logger : ILoggable
    {
        public void Log(string stringToLog)
        {
            Console.WriteLine($"Log: {stringToLog}");
        }
    }
}
