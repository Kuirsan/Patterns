﻿namespace Factory
{
    class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            _name = "NY style sauce and cheese pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";

            _toppings.Add("Grated Reggiano Cheese");
        }
    }
}