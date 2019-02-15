using AbstractFactory.Factory.Ingredients;

namespace AbstractFactory.Factory
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