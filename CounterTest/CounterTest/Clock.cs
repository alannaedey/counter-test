using System;
namespace CounterTest
{
    public class Clock
    {
        private Counter[] _counters;


        public Clock()
        {
            _counters = new Counter[3];
            _counters[0] = new Counter("Seconds");
            _counters[1] = new Counter("Minutes");
            _counters[2] = new Counter("Hours");
        }


        public void Tick()
        {
            _counters[0].Increment();
            if (_counters[0].Value == 60)
            {
                _counters[0].Reset();
                _counters[1].Increment();
            }

            if (_counters[1].Value == 60)
            {
                _counters[1].Reset();
                _counters[2].Increment();
            }

            if (_counters[2].Value == 24)
            {
                _counters[2].Reset();
            }
        }


        public void Reset()
        {
            _counters[0].Reset();
            _counters[1].Reset();
            _counters[2].Reset();
        }

        public string Value{
            get{
                return String.Format("{0:00}:{1:00}:{2:00}", _counters[2].Value, _counters[1].Value, _counters[0].Value );
            }
        }
    }


}
