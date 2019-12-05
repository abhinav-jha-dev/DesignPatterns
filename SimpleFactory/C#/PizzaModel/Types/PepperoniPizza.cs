using System;

namespace SimpleFactory.PizzaModel.Types
{
    public class PepperoniPizza : IPizza
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