using System;

namespace Strategy.Behavior.Flying
{
    public class FlyWithWings : IFlyingBehavior
    {
        public void Fly() => Console.WriteLine("Flying with Wings!");
    }
}