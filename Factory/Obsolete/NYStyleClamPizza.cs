using System;

namespace Factory
{
    [Obsolete("Use ClamPizza")]
    internal class NYStyleClamPizza : Pizza
    {
        public override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}