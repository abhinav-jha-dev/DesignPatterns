using System;

namespace Creational_FactoryMethod.PizzaItems.Types
{
    public class NYStylePepperoniPizza : IPizza
    {
        public void bake()
        {
            Console.WriteLine("Backing Pepperoni Pizza");
        }

        public void box()
        {
            Console.WriteLine("Boxing Pepperoni Pizza");
        }

        public void cut()
        {
            Console.WriteLine("Cutting Pepperoni Pizza");
        }

        public void prepare()
        {
            Console.WriteLine("Preparing Pepperoni Pizza");
        }
    }
}