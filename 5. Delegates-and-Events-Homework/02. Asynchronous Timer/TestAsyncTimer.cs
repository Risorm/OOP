using System;

namespace _02.Asynchronous_Timer
{
    public static class TestAsyncTimer
    {
        static void Work(int num)
        {
            Console.WriteLine(num);
        }

        static void Main()
        {
            AsyncTimer timer = new AsyncTimer(Work, 1000, 10);
            timer.Start();
        }
    }
}