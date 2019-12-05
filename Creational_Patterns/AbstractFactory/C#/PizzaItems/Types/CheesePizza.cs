using System;
using System.Collections.Generic;
using AbstractFactory.Factory;
using AbstractFactory.Factory.Ingredients;

namespace AbstractFactory.PizzaItems.Types
{
    public class CheesePizza : Pizza
    {
        private readonly IIngredientsFactory _ingredientFactory;
        
        public CheesePizza(IIngredientsFactory ingredientFactory)
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
        }
    }
}