using System;

namespace Strategy.Behavior.Flying
{
    public class FlyNoWay : IFlyingBehavior
    {
        public void Fly() => Console.WriteLine("I can't fly!");
    }
}