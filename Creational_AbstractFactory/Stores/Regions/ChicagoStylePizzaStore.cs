using System;
using Creational_AbstractFactory.Factory;
using Creational_AbstractFactory.PizzaItems;
using Creational_AbstractFactory.PizzaItems.Types;

namespace Creational_AbstractFactory.Stores.Regions
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            cutStyle = "square";
            Pizza pizza = null;
            IIngredientsFactory ingredientsFactory = new ChicagoPizzaIngredientsFactory();
            switch (type)
            {
                case "Cheese":
                    pizza = new CheesePizza(ingredientsFactory);
                    pizza.setName("Chicago Style Cheese Pizza");
                    break;
                case "Clam":
                    pizza = new ClamPizza(ingredientsFactory);
                    pizza.setName("Chicago Style Clam Pizza");
                    break;
                default:
                    Console.WriteLine("Please select valid pizza type.");
                    break;
            }
            return pizza;
        }
    }
}