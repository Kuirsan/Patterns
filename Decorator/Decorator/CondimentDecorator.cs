using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class CondimentDecorator:Beverage
    {
        public override abstract string GetDescription();
    }
}
