using System;

namespace SimpleFactory.PizzaModel.Types
{
    public class VeggiePizza : IPizza
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