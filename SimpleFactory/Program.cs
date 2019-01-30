using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here I am declaring my Pizza Factory and the Store which I will use to place order.
            PizzaFactory myPizzaFactory = new PizzaFactory();
            PizzaStore myPizzaStore = new PizzaStore(myPizzaFactory);

            Console.WriteLine("Welcome to my Pizza Store!");
            Console.WriteLine("Please enter your pizza type from");
            Console.WriteLine("(Cheese)(Veggie)(Clam)(Pepperoni)");
            var pizzaType = Console.ReadLine();

            // Here I have used my Store to place my order and asked it to create pizza based on its type.
            var pizza = myPizzaStore.OrderPizza(pizzaType);

            // Here I am returning my pizza that I have received from the factory.
            if (pizza != null)
                Console.WriteLine("Thank for Ordering " + pizza.GetType() + " please collect your order from front desk in 15 min");
            else
                Console.WriteLine("We are sorry to serve you today. Facing issue with the system.");
        }
    }
}
