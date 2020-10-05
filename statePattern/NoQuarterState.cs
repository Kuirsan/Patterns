﻿using System;
using System.Collections.Generic;
using System.Text;

namespace statePattern
{
    public class NoQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.SetState(_gumballMachine.GetHasQuarterState());
        }

        public void TurnCranc()
        {
            Console.WriteLine("You turned, but there is no quarter");
        }
        public override string ToString()
        {
            return "waiting for quarter";
        }
    }
}
