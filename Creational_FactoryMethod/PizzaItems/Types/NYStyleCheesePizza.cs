using System;
using System.Collections.Generic;

namespace Creational_FactoryMethod.PizzaItems.Types
{
    public class NYStyleCheesePizza : Pizza
    {
        public override string name { get; set; }
        public override string dough { get; set; }
        public override string sauce { get; set; }
        public override List<string> toppings { get; set; }= new List<string>();

        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}