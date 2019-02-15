using Creational_AbstractFactory.Factory.Ingredients;

namespace Creational_AbstractFactory.Factory
{
    public class NYPizzaIngredientFactory : IIngredientsFactory
    {
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Clams CreateClam()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new Pepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies[] { new GarlicVeggie(), new OnionVeggie() };
        }
    }
}