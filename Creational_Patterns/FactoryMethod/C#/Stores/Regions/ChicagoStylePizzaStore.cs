using System;
using FactoryMethod.PizzaItems;
using FactoryMethod.PizzaItems.Types;

namespace FactoryMethod.Stores.Regions
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "Cheese":
                    pizza = new ChicagoStyleCheesePizza();
                    break;
                case "Clam":
                    pizza = new ChicagoStyleClamPizza();
                    break;
                default:
                    Console.WriteLine("Please select valid pizza type.");
                    break;
            }
            return pizza;
        }
    }
}