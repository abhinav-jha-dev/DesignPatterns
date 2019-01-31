namespace Creational_FactoryMethod.PizzaItems
{
    public interface IPizza
    {
        void prepare();
        void bake();
        void cut();
        void box();
    }
}