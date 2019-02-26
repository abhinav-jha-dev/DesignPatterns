using System;

namespace Strategy.Behavior.Quack
{
    public class SQuack : IQuackBehavior
    {
        public void QuackBehavior() => Console.WriteLine("SQuack! SQuack!! SQuack!!!");
    }
}