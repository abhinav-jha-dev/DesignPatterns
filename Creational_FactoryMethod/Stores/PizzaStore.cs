using Creational_FactoryMethod.PizzaItems;

namespace Creational_FactoryMethod.Stores
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }
}