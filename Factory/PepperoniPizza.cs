using Factory.Ingredients;
using System;

namespace Factory
{
    internal class PepperoniPizza : Pizza
    {
        private IPizzaIngredientFactory _pizzaIngredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this._pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + _name);
            _dough = _pizzaIngredientFactory.createDough();
            _sauce = _pizzaIngredientFactory.createSauce();
            _cheese = _pizzaIngredientFactory.createCheese();
            _pepperoni = _pizzaIngredientFactory.createPepperoni();
        }
    }
}