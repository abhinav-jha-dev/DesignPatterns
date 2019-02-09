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