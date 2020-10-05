using statePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class GumballMonitor
    {
        public GumballMachine _machine;
        public GumballMonitor(GumballMachine gumballMachine)
        {
            _machine = gumballMachine;
        }

        public void Report()
        {
            Console.WriteLine("Gumball machine: " + _machine.GetLocation());
            Console.WriteLine("Current inventory: " + _machine.GetCount());
            Console.WriteLine("Current state: " + _machine.GetState());
        }
    }
}
