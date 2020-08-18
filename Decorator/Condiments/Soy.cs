using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Condiments
{
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double cost()
        {
            return 0.15 + _beverage.cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }
    }
}
