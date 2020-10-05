namespace statePattern
{
    public class SoldState : IState
    {
        private GumballMachine gumballMachine;

        public SoldState(GumballMachine gumballMachine)
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