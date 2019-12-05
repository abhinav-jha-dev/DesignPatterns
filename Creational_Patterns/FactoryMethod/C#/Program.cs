using System;
using FactoryMethod.Stores;
using FactoryMethod.Stores.Regions;

namespace FactoryMethod
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Here I am declaring both of my Pizza Store to order same type of pizza for both of the store.
            PizzaStore NYPizzaStore = new NYStylePizzaStore();
            PizzaStore ChicagoPizzaStore = new ChicagoStylePizzaStore();

            Console.WriteLine("Welcome to my Pizza Store!");
            Console.WriteLine("Please enter your pizza type from");
            Console.WriteLine("(Cheese)(Clam)");
            var pizzaType = Console.ReadLine();

            // Now NY Pizza Store is prepare my order.
            var NYPizza = NYPizzaStore.OrderPizza(pizzaType);

            // Here I am returning my pizza that I have received from NY Pizza Store.
            if (NYPizza != null)
                Console.WriteLine("Thank for Ordering " + NYPizza.GetType() + " please collect your order from front desk in 15 min");
            else
                Console.WriteLine("We are sorry to serve you today. Facing issue with the system.");
            
            // Now Chicago Pizza Store is prepare my order.
            var ChicagoPizza = ChicagoPizzaStore.OrderPizza(pizzaType);

            // Here I am returning my pizza that I have received from NY Pizza Store.
            if (ChicagoPizza != null)
                Console.WriteLine("Thank for Ordering " + ChicagoPizza.GetType() + " please collect your order from front desk in 15 min");
            else
                Console.WriteLine("We are sorry to serve you today. Facing issue with the system.");
        }
    }
}
