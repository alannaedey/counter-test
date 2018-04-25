using System;
using NUnit.Framework;
namespace CounterTest
{
    [TestFixture]
    public class ClockTest
    {
        [Test]
        public void TestInitialise()
        {
            Clock clock = new Clock();

            if (clock.Value != "00:00:00")
            {
                Assert.Fail("Initialise Test has Failed!");
            }
        }

        [Test]
        public void TestTickSecToMin()
        {
            Clock clock = new Clock();
            for (int i = 0; i < 60; i++)
            {
                clock.Tick();
            }
            if (clock.Value != "00:01:00")
            {
                Assert.Fail("Tick Sec To Min Test has Failed!");
            }
        }

        [Test]
        public void TestTickMinToHour()
        {
            Clock clock = new Clock();
            for (int i = 0; i < 3600; i++)
            {
                clock.Tick();
            }
            if (clock.Value != "01:00:00")
            {
                Assert.Fail("Tick Test Min To Hour has Failed!");
            }
        }

        [Test]
        public void TestTickHour()
        {
            Clock clock = new Clock();
            for (int i = 0; i < 86400; i++)
            {
                clock.Tick();
            }
            if (clock.Value != "00:00:00")
            {
                Assert.Fail("Tick Test Hour has Failed!");
            }
        }


        [Test]
        public void TestReset()
        {
            Clock clock = new Clock();
            clock.Tick();
            clock.Tick();
            clock.Tick();
            clock.Reset();

            if (clock.Value != "00:00:00")
            {
                Assert.Fail("Reset Test has Failed!");
            }
        }
    }
}
