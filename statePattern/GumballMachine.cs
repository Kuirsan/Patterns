using System;

namespace statePattern
{
    public class GumballMachine
    {
        private static IState _soldOutState;
        private static IState _noQuarterState;
        private static IState _hasQuarterState;
        private static IState _soldState;
        private string _location;

        private IState _state = _soldOutState;
        private int _count;

        public GumballMachine(string location,int numberGumballs)
        {
            _soldOutState = new SoldState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _location = location;

            if (numberGumballs > 0)
            {
                _state = _noQuarterState;
                _count = numberGumballs;
            }
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCranc();
            _state.Dispense();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        private void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (_count != 0)
            {
                _count--;
            }
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }
        public string GetLocation()
        {
            return _location;
        }
        public int GetCount()
        {
            return _count;
        }
        public IState GetState()
        {
            return _state;
        }
    }
}