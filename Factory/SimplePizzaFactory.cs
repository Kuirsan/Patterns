using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
            {
                pizza = CheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = PepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = ClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = VeggiePizza();
            }
        }
    }
}
