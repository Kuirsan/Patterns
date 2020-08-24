using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            throw new NotImplementedException();
        }
    }
}
