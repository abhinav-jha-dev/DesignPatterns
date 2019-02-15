using System;
using Creational_AbstractFactory.Factory;
using Creational_AbstractFactory.PizzaItems;
using Creational_AbstractFactory.PizzaItems.Types;

namespace Creational_AbstractFactory.Stores.Regions
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IIngredientsFactory ingredientsFactory = new NYPizzaIngredientFactory();
            switch (type)
            {
                case "Cheese":
                    pizza = new CheesePizza(ingredientsFactory);
                    pizza.setName("NY Style Cheese Pizza");
                    break;
                case "Clam":
                    pizza = new ClamPizza(ingredientsFactory);
                    pizza.setName("NY Style Clam Pizza");
                    break;
                default:
                    Console.WriteLine("Please select valid pizza type.");
                    break;
            }
            return pizza;
        }
    }
}