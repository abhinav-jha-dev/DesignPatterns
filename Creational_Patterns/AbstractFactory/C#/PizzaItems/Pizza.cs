using System;
using System.Collections.Generic;
using AbstractFactory.Factory.Ingredients;

namespace AbstractFactory.PizzaItems
{
    // We will start with the abstract pizza class and all the concrete class will drive from it
    public abstract class Pizza
    {
        public string name { get; set; }
        public Dough dough { get; set; }
        public Sauce sauce { get; set; }
        public Veggies[] Veggies { get; set; }
        public Cheese cheese { get; set; }
        public Clams clams { get; set; }

        public abstract void prepare();

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minute at 350.");
        }

        public virtual void cut(string cutStyle)
        {
            Console.WriteLine("Cutting the pizza into " + cutStyle + " slices.");
        }

        public virtual void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box.");
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
    }
}