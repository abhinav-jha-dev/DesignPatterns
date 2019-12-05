using Strategy.Behavior;
using Strategy.Behavior.Flying;
using Strategy.Behavior.Quack;

namespace Strategy.Ducks
{
    public abstract class Duck
    {
        private IFlyingBehavior _flyingBehavior;
        private IQuackBehavior _quackBehavior;

        public Duck()
        {
            Display();
            Swim();
        }

        protected abstract void Display();
        protected void SetFlyBehavior(IFlyingBehavior flyingBehavior) => _flyingBehavior = flyingBehavior;
        protected void SetQuackBehavior(IQuackBehavior quackBehavior) => _quackBehavior = quackBehavior;
        public void PerformFlyBehavior() => _flyingBehavior.Fly();
        public void PerformQuackBehavior() => _quackBehavior.QuackBehavior();
        private void Swim() => new SwimBehavior();

    }
}