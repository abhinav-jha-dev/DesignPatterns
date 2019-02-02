using System;
using System.Collections.Generic;

namespace Creational_FactoryMethod.PizzaItems.Types
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public override string name { get; set; }
        public override string dough { get; set; }
        public override string sauce { get; set; }
        public override List<string> toppings { get; set; } = new List<string>();

        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices.");
        }
    }
}