using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Espresso:Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
