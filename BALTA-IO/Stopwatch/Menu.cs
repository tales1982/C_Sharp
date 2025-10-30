// Menu.cs
using System;
using System.Threading;

namespace StopwatchApp
{
    public struct Menu
    {
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("__________________________________");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|               MENU              |");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine("|  Choose from the options below  |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|  1S = Timer in Seconds          |");
            Console.WriteLine("|  1M = Timer in Minutes          |");
            Console.WriteLine("|  0  = Exit                      |");
            Console.WriteLine("|_________________________________|");
            Console.WriteLine();
            Thread.Sleep(400);
        }

        public void PreStart()
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(500);
            Console.WriteLine("Set...");
            Thread.Sleep(500);
            Console.WriteLine("Go...");
            Thread.Sleep(500);
            Console.WriteLine();
        }
    }
}
