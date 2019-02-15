using Creational_AbstractFactory.PizzaItems;

namespace Creational_AbstractFactory.Stores
{
    public abstract class PizzaStore
    {
        public string cutStyle = "diagonal";
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut(cutStyle);
            pizza.box();

            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }
}