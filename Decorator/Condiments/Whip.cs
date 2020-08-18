using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double cost()
        {
            return 0.10 + _beverage.cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }
    }
}
