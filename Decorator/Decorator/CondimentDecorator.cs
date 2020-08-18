using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class CondimentDecorator:Beverage
    {
        public new abstract string GetDescription();
    }
}
