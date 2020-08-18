using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class DarkRoast:Beverage
    {
        public DarkRoast()
        {
            _description = "Dark roast Coffee";
        }

        public override double cost()
        {
            return 0.99;
        }
    }
}
