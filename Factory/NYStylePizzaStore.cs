using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                return new NYStyleVeggiePizza();
            }
            else if (type.Equals("clam"))
            {
                return new NYStyleClamPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new NYStylePepperoniPizza();
            }
            return new NYStyleCheesePizza();
        }
    }
}
