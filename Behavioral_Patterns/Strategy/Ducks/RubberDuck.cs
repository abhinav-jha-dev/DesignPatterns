using System;
using Strategy.Behavior.Flying;
using Strategy.Behavior.Quack;

namespace Strategy.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            base.SetFlyBehavior(new FlyNoWay());
            base.SetQuackBehavior(new SQuack());
        }

        protected override void Display() => Console.WriteLine("Hello I am RedHead Duck I can't fly but I can SQuack!");
    }
}