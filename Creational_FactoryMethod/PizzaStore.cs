using Creational_FactoryMethod.PizzaItems;

namespace Creational_FactoryMethod
{
    public abstract class PizzaStore
    {
        public IPizza OrderPizza(string type)
        {
            IPizza pizza;
            pizza = CreatePizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        public abstract IPizza CreatePizza(string type);
    }
}