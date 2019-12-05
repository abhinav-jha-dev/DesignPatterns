using System;
using Strategy.Behavior.Flying;
using Strategy.Behavior.Quack;

namespace Strategy.Ducks
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            base.SetFlyBehavior(new FlyWithWings());
            base.SetQuackBehavior(new Quack());
        }

        protected override void Display() => Console.WriteLine("Hello I am RedHead Duck I can fly and quack!");
    }
}