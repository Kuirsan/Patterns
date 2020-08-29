using System;

namespace Factory
{
    [Obsolete("Use CheesePizza")]
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            _name = "Chicago Style deep dish cheese pizza";
            //_dough = "extra thick crust dough";
            //_sauce = "Plum Tomato sauce";

            _toppings.Add("Shredded Mozarella Cheese");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting pizza into square slices");
        }

        public override void prepare()
        {
            throw new NotImplementedException();
        }
    }
}