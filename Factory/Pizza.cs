using Factory.Ingredients;
using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class Pizza
    {
        protected string _name;
        protected Dough _dough;
        protected Sauce _sauce;
        protected Veggies[] _veggies;
        protected Cheese _cheese;
        protected Pepperoni _pepperoni;
        protected Clams _clams;
        protected List<string> _toppings = new List<string>();
        public abstract void prepare();

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        internal void SetName(string v)
        {
            _name = v;
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
        public override string ToString()
        {
            return base.ToString();
        }
    }
}