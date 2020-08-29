using System;

namespace Factory
{
    [Obsolete("Use VeggiePizza")]
    internal class NYStyleVeggiePizza : Pizza
    {
        public override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}