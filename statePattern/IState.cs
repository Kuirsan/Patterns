using System;
using System.Collections.Generic;
using System.Text;

namespace statePattern
{
    interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCranc();
        void Dispense();
    }
}
