using System;
using SimpleFactory.PizzaModel;
using SimpleFactory.PizzaModel.Types;

namespace SimpleFactory
{
    public class PizzaFactory
    {
        public IPizza CreatePizza(string type)
        {
            IPizza pizza = null;
            switch (type)
            {
                case "Cheese":
                    pizza = new CheesePizza();
                    break;
                case "Veggie":
                    pizza = new VeggiePizza();
                    break;
                case "Clam":
                    pizza = new ClamPizza();
                    break;
                case "Pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                default:
                    Console.WriteLine("Please select valid pizza type.");
                    break;
            }

            // This will create my pizza based on the process defined in different pizza's
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}