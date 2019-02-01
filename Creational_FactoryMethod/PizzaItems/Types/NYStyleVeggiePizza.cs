using System;

namespace Creational_FactoryMethod.PizzaItems.Types
{
    public class NYStyleVeggiePizza : IPizza
    {
        public void bake()
        {
            Console.WriteLine("Backing Veggie Pizza");
        }

        public void box()
        {
            Console.WriteLine("Boxing Veggie Pizza");
        }

        public void cut()
        {
            Console.WriteLine("Cutting Veggie Pizza");
        }

        public void prepare()
        {
            Console.WriteLine("Preparing Veggie Pizza");
        }
    }
}