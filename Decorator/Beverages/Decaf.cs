using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Decaf:Beverage
    {
        public Decaf()
        {
            _description = "Decaf coffee";
        }

        public override double cost()
        {
            return 1.05;
        }
    }
}
