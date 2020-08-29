using System;

namespace Factory
{
    [Obsolete("Use PepperoniPizza")]
    internal class ChicagoStylePepperoniPizza : Pizza
    {
        public override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}