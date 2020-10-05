using ProxyPattern;
using statePattern;
using System;

namespace ProxyPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            if (args.Length < 2)
            {
                Console.WriteLine("GumballMachine <name> <inventory>");
                Environment.Exit(1);
            }

            count = int.Parse(args[1]);
            GumballMachine gumballMachine = new GumballMachine(args[0], count);

            GumballMonitor gumballMonitor = new GumballMonitor(gumballMachine);

            gumballMonitor.Report();
        }
    }
}
