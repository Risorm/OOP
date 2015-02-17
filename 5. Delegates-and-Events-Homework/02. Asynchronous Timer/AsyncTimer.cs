using System;
using System.Threading;

namespace _02.Asynchronous_Timer
{
    class AsyncTimer
    {
        public AsyncTimer(Action<int> action, int interval, int ticks)
        {
            this.Action = action;
            this.Interval = interval;
            this.Ticks = ticks;
        }

        public Action<int> Action { get; set; }

        public int Interval { get; set; }

        public int Ticks { get; set; }

        private void DoWork()
        {
            while (this.Ticks > 0)
            {
                Thread.Sleep(this.Interval);
                if (Action != null)
                {
                    Action(this.Ticks);
                }
                this.Ticks--;
            }
        }
        public void Start()
        {
            Thread thread = new Thread(this.DoWork);
            thread.Start();
        }
    }

}
