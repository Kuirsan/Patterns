using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                return new ChicagoStyleVeggiePizza();
            }
            else if (type.Equals("clam"))
            {
                return new ChicagoStyleClamPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                return new ChicagoStylePepperoniPizza();
            }
            return new ChicagoStyleCheesePizza();
        }
    }
}
