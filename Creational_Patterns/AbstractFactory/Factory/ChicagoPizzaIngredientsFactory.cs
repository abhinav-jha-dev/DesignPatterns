using AbstractFactory.Factory.Ingredients;

namespace AbstractFactory.Factory
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