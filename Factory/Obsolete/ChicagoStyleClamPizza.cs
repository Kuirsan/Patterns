using System;

namespace Factory
{
    [Obsolete("Use ClamPizza")]
    internal class ChicagoStyleClamPizza : Pizza
    {
        public override void prepare()
        {
            throw new System.NotImplementedException();
        }
    }
}