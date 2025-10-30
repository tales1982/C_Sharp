// Timing.cs
using System;
using System.Threading;

namespace StopwatchApp
{
    public struct Timing
    {
        public void ConvertSeconds(int seconds)
        {
            if (seconds <= 0) return;

            while (seconds >= 0)
            {
                Console.Clear();
                Console.WriteLine($"{seconds:D2}");
                Thread.Sleep(1000);
                seconds--;
            }

            Console.WriteLine("Tempo esgotado!");
            Thread.Sleep(800);
        }

        public void ConvertMinutes(int minutes)
        {
            if (minutes <= 0) return;

            int totalSeconds;
            try
            {
                totalSeconds = checked(minutes * 60);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Valor muito grande (overflow).");
                Thread.Sleep(1000);
                return;
            }

            while (totalSeconds >= 0)
            {
                int min = totalSeconds / 60;
                int sec = totalSeconds % 60;

                Console.Clear();
                Console.WriteLine($"{min:D2}:{sec:D2}");
                Thread.Sleep(1000);
                totalSeconds--;
            }

            Console.WriteLine("Tempo esgotado!");
            Thread.Sleep(800);
        }
    }
}
