using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class Pizza
    {
        protected string _name;
        protected string _dough;
        protected string _sauce;
        protected List<string> _toppings = new List<string>();
        public virtual void prepare()
        {
            Console.WriteLine("Preparing " + _name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach(var topping in _toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public virtual string getName()
        {
            return _name;
        }
    }
}