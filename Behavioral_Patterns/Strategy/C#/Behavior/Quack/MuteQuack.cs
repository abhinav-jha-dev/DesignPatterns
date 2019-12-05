using System;

namespace Strategy.Behavior.Quack
{
    public class MuteQuack : IQuackBehavior
    {
        public void QuackBehavior() => Console.WriteLine("I can't Quack!");
    }
}