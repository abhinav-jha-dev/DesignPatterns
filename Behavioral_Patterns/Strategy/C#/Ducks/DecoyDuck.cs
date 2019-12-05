using System;
using Strategy.Behavior.Flying;
using Strategy.Behavior.Quack;

namespace Strategy.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            base.SetFlyBehavior(new FlyNoWay());
            base.SetQuackBehavior(new MuteQuack());
        }

        protected override void Display() => Console.WriteLine("Hello I am Decoy Duck I can't fly or quack!");
    }
}