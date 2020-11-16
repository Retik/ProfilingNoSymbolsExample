using System.Diagnostics;
using System.Threading;

namespace ProfilingTest
{
    public class ExampleClass
    {
        public void Sleep100ms()
        {
            Thread.Sleep(100);
        }

        public void Delay100ms()
        {
            var stopwatch = Stopwatch.StartNew();
            while(stopwatch.ElapsedMilliseconds < 100) { }
        }
    }
}
