using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class Mocha:CondimentDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double cost()
        {
            return 0.20 + _beverage.cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }
    }
}
