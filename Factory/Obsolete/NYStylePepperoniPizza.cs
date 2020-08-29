using System;

namespace Factory
{
    [Obsolete("Use PepperoniPizza")]
    internal class NYStylePepperoniPizza : Pizza
    {
        public override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}