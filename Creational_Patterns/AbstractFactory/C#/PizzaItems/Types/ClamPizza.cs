using System;
using System.Collections.Generic;
using AbstractFactory.Factory;

namespace AbstractFactory.PizzaItems.Types
{
    public class ClamPizza : Pizza
    {
        private readonly IIngredientsFactory _ingredientFactory;
        public ClamPizza(IIngredientsFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = _ingredientFactory.CreateDough();
            sauce = _ingredientFactory.CreateSauce();
            cheese = _ingredientFactory.CreateCheese();
            clams = _ingredientFactory.CreateClam();
            Veggies = _ingredientFactory.CreateVeggies();
        }
    }
}