using System;

namespace Creational_FactoryMethod.PizzaItems.Types
{
    public class ChicagoStyleCheesePizza : IPizza
    {
        public void bake()
        {
            Console.WriteLine("Backing Cheese Pizza");
        }

        public void box()
        {
            Console.WriteLine("Boxing Cheese Pizza");
        }

        public void cut()
        {
            Console.WriteLine("Cutting Cheese Pizza");
        }

        public void prepare()
        {
            Console.WriteLine("Preparing Cheese Pizza");
        }
    }
}