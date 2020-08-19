using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class Beverage
    {
        protected string _description = "Unknown beverage";
        public virtual string GetDescription()
        {
            return _description;
        }

        public abstract double cost();
    }
}
