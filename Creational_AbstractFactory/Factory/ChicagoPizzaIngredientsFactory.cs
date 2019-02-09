using Creational_AbstractFactory.Factory.Ingredients;

namespace Creational_AbstractFactory.Factory
{
    public class ChicagoPizzaIngredientsFactory : IIngredientsFactory
    {
        public Cheese CreateCheese()
        {
            throw new System.NotImplementedException();
        }

        public Clams CreateClam()
        {
            throw new System.NotImplementedException();
        }

        public Dough CreateDough()
        {
            throw new System.NotImplementedException();
        }

        public Pepperoni CreatePepperoni()
        {
            throw new System.NotImplementedException();
        }

        public Sauce CreateSauce()
        {
            throw new System.NotImplementedException();
        }

        public Veggies[] CreateVeggies()
        {
            throw new System.NotImplementedException();
        }
    }
}