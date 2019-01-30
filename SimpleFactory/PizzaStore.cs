using SimpleFactory.PizzaModel;

namespace SimpleFactory
{
    public class PizzaStore
    {
        private readonly PizzaFactory _pizzaFactory;

        public PizzaStore(PizzaFactory pizzaFactory)
        {
            _pizzaFactory = pizzaFactory;
        }

        public IPizza OrderPizza(string type)
        {
            return _pizzaFactory.CreatePizza(type);
        }
    }
}