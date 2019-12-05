using System;
using Strategy.Behavior.Flying;
using Strategy.Behavior.Quack;

namespace Strategy.Ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            base.SetFlyBehavior(new FlyWithWings());
            base.SetQuackBehavior(new Quack());
        }

        protected override void Display() => Console.WriteLine("Hello I am Mallard Duck I can fly and quack!");
    }
}