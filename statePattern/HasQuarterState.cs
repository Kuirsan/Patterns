namespace statePattern
{
    public class HasQuarterState : IState
    {
        private GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            throw new System.NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new System.NotImplementedException();
        }

        public void InsertQuarter()
        {
            throw new System.NotImplementedException();
        }

        public void TurnCranc()
        {
            throw new System.NotImplementedException();
        }
    }
}