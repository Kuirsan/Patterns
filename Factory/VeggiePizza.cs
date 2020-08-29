using Factory.Ingredients;
using System;

namespace Factory
{
    internal class VeggiePizza : Pizza
    {
        private IPizzaIngredientFactory _pizzaIngredientFactory;

        public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            this._pizzaIngredientFactory = pizzaIngredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + _name);
            _dough = _pizzaIngredientFactory.createDough();
            _sauce = _pizzaIngredientFactory.createSauce();
            _cheese = _pizzaIngredientFactory.createCheese();
            _veggies = _pizzaIngredientFactory.createVeggies();
        }
    }
}