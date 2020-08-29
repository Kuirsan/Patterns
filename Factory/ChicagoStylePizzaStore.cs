using Factory.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory pizzaIngredientFactory = new ChicagoPizzaIngredientFactory();
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(pizzaIngredientFactory);
                pizza.SetName("Chicago Style Cheese Pizza");
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(pizzaIngredientFactory);
                pizza.SetName("Chicago Style Veggie Pizza");
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(pizzaIngredientFactory);
                pizza.SetName("Chicago Style Clam Pizza");
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(pizzaIngredientFactory);
                pizza.SetName("Chicago Style Pepperoni Pizza");
            }
            return pizza;
        }
    }
}
