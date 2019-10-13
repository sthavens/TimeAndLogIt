using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeAndLogIt
{
    class TimeAndLogIt
    {
        public delegate void functionToTimeAndLog();
        public void Process(functionToTimeAndLog function)
        {
            Timer timer = new Timer();
            Logger logger = new Logger();
            timer.Start();
            function.Invoke();
            timer.Stop();
            string time = timer.GetResult().ToString();
            logger.Log($"The time to process the function was {time}.");
        }

    }
    class Program
    {
        private static void TestFunction()
        {
            Console.WriteLine("Function Started");
            Thread.Sleep(3000);
            Console.WriteLine("Function Completed");
        }
        static void Main(string[] args)
        {
            TimeAndLogIt timeAndLogIt = new TimeAndLogIt();
            TimeAndLogIt.functionToTimeAndLog functionToTimeAndLog= new TimeAndLogIt.functionToTimeAndLog(TestFunction);
            timeAndLogIt.Process(functionToTimeAndLog);
        }
    }
}
