using System;

namespace SimpleFactory.PizzaModel.Types
{
    public class ClamPizza : IPizza
    {
        public void bake()
        {
            Console.WriteLine("Backing Clam Pizza");
        }

        public void box()
        {
            Console.WriteLine("Boxing Clam Pizza");
        }

        public void cut()
        {
            Console.WriteLine("Cutting Clam Pizza");
        }

        public void prepare()
        {
            Console.WriteLine("Preparing Clam Pizza");
        }
    }
}