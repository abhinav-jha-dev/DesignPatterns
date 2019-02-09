using System;
using System.Collections.Generic;

namespace Creational_AbstractFactory.PizzaItems.Types
{
    public class NYStyleClamPizza : Pizza
    {
        public override string name { get; set; }
        public override string dough { get; set; }
        public override string sauce { get; set; }
        public override List<string> toppings { get; set; } = new List<string>();

        public NYStyleClamPizza()
        {
            name = "NY Style Clam Pizza";
            dough = "Extra thin Crust Dough";
            sauce = "Egg Plant Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}