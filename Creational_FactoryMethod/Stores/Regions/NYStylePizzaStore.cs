using System;
using Creational_FactoryMethod.PizzaItems;
using Creational_FactoryMethod.PizzaItems.Types;

namespace Creational_FactoryMethod.Stores.Regions
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "Cheese":
                    pizza = new NYStyleCheesePizza();
                    break;
                case "Clam":
                    pizza = new NYStyleClamPizza();
                    break;
                default:
                    Console.WriteLine("Please select valid pizza type.");
                    break;
            }
            return pizza;
        }
    }
}