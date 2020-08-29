using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Ingredients
{
    public interface IPizzaIngredientFactory
    {
        public Dough createDough();
        public Sauce createSauce();
        public Cheese createCheese();
        public Veggies[] createVeggies();
        public Pepperoni createPepperoni();
        public Clams createClam();
    }
}
