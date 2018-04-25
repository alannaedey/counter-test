using System;

namespace CounterTest
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Clock clock = new Clock();

            for (int i = 0; i < 56700; i++)
            {
                clock.Tick();
            }

            Console.WriteLine(clock.Value);

            clock.Reset();

            for (int i = 0; i < 23456; i++)
            {
                clock.Tick();
            }

            Console.WriteLine(clock.Value);
        }



    }
}
