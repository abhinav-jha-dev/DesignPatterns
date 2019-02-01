using Creational_FactoryMethod.PizzaItems;

namespace Creational_FactoryMethod.Stores.Regions
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            throw new System.NotImplementedException();
        }
    }
}