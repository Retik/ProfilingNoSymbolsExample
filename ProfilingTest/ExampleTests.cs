using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace ProfilingTest
{
    [TestClass]
    public class ExampleTests
    {
        private ExampleClass target;

        public ExampleTests()
        {
            target = new ExampleClass();
        }

        [TestMethod]
        public void Sleep100ms_SleepsAtLeast100Ms()
        {
            var stopwatch = Stopwatch.StartNew();
            target.Sleep100ms();
            stopwatch.Stop();

            Assert.IsTrue(stopwatch.ElapsedMilliseconds >= 100, $"Expected elapsed ms to be greater than or equal to 100 but was {stopwatch.ElapsedMilliseconds}");
        }

        [TestMethod]
        public void Delay100ms_DelaysCorrectTime()
        {
            var stopwatch = Stopwatch.StartNew();
            target.Delay100ms();
            stopwatch.Stop();

            Assert.IsTrue(stopwatch.ElapsedMilliseconds >= 100, $"Expected elapsed ms to be greater than or equal to 100 but was {stopwatch.ElapsedMilliseconds}");
        }
    }
}
