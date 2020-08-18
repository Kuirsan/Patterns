using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            _description = "House Blend Coffee";
        }

        public override double cost()
        {
            return 0.89;
        }
    }
}
