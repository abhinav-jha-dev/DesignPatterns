using Creational_AbstractFactory.Factory.Ingredients;

namespace Creational_AbstractFactory.Factory
{
    public interface IIngredientsFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Veggies[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClam();
    }
}