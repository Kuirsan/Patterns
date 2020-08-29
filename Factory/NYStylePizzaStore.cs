using Factory.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory pizzaIngredientFactory = new NYPizzaIngredientFactory();
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza(pizzaIngredientFactory);
                pizza.SetName("New York Style Cheese Pizza");
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza(pizzaIngredientFactory);
                pizza.SetName("New York Style Veggie Pizza");
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza(pizzaIngredientFactory);
                pizza.SetName("New York Style Clam Pizza");
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(pizzaIngredientFactory);
                pizza.SetName("New York Style Pepperoni Pizza");
            }
            return pizza;
        }
    }
}
