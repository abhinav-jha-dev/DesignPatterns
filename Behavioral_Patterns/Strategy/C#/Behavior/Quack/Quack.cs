using System;

namespace Strategy.Behavior.Quack
{
    public class Quack : IQuackBehavior
    {
        public void QuackBehavior() => Console.WriteLine("Quack! Quack!! Quack!!!");
    }
}