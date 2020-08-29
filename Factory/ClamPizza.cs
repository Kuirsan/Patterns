using Factory.Ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class ClamPizza:Pizza
    {
        private IPizzaIngredientFactory _pizzaIngredientFactory;

        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + _name);
            _dough = _pizzaIngredientFactory.createDough();
            _sauce = _pizzaIngredientFactory.createSauce();
            _cheese = _pizzaIngredientFactory.createCheese();
            _clams = _pizzaIngredientFactory.createClam();
        }
    }
}
