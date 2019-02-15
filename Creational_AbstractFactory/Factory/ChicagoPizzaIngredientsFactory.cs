using Creational_AbstractFactory.Factory.Ingredients;

namespace Creational_AbstractFactory.Factory
{
    public class ChicagoPizzaIngredientsFactory : IIngredientsFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clams CreateClam()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new Pepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies[] { new EggPlantVeggie(), new OnionVeggie(), new GarlicVeggie() };
        }
    }
}