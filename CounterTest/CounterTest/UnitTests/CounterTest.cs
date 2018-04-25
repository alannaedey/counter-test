using System;
using NUnit.Framework;
namespace CounterTest
{
    [TestFixture]
    public class CounterTest
    {
        [Test]
        public void TestInitialise()
        {
            Counter count = new Counter("Banana");

            if (count.Value != 0)
            {
                Assert.Fail("Initialise Test has Failed!");
            }
        }

        [Test]
        public void TestIncrement()
        {
            Counter count = new Counter("Banana");
            count.Increment();

            if (count.Value != 1)
            {
                Assert.Fail("Increment Test has Failed!");
            }
        }

        [Test]
        public void TestMultipleIncrement()
        {
            Counter count = new Counter("Banana");
            count.Increment();
            count.Increment();
            count.Increment();

            if (count.Value != 3)
            {
                Assert.Fail("Multiple Increment Test has Failed!");
            }
        }

        [Test]
        public void TestReset()
        {
            Counter count = new Counter("Banana");
            count.Increment();
            count.Increment();
            count.Increment();
            count.Reset();

            if (count.Value != 0)
            {
                Assert.Fail("Reset Test has Failed!");
            }
        }

    }
}
