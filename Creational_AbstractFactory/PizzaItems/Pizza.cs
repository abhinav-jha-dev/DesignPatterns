using System;
using System.Collections.Generic;

namespace Creational_AbstractFactory.PizzaItems
{
    // We will start with the abstract pizza class and all the concrete class will drive from it
    public abstract class Pizza
    {
        public abstract string name { get; set; }
        public abstract string dough { get; set; }
        public abstract string sauce { get; set; }
        public abstract List<string> toppings { get; set; }

        public virtual void prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minute at 350.");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices.");
        }

        public virtual void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box.");
        }

        public string getName()
        {
            return name;
        }
    }
}