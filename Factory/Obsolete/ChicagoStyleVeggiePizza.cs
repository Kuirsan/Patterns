using System;

namespace Factory
{
    [Obsolete("Use VeggiePizza")]
    internal class ChicagoStyleVeggiePizza : Pizza
    {
        public override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}