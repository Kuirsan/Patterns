using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Ingredients
{
    public class ChicagoPizzaIngredientFactory:IPizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new MozarellaCheese();
        }

        public Clams createClam()
        {
            return new FreshClams();
        }

        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        public Veggies[] createVeggies()
        {
            Veggies[] veggies = new Veggies[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }
    }
}
