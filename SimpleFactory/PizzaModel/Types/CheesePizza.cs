using System;

namespace SimpleFactory.PizzaModel.Types
{
    public class CheesePizza : IPizza
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