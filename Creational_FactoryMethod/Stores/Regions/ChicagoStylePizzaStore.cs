using Creational_FactoryMethod.PizzaItems;

namespace Creational_FactoryMethod.Stores.Regions
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(string type)
        {
            throw new System.NotImplementedException();
        }
    }
}