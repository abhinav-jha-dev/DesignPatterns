using System;
using Strategy.Ducks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the SimUDuck Simulator.");
            Console.WriteLine("Please select the duck:\n" +
            "1. Mallard Duck.\n" +
            "2. Redhead Duck.\n" +
            "3. Decoy Duck.\n" +
            "4. Rubber Dock.\n");
            var duckType = Convert.ToInt32(Console.ReadLine());
            
            Duck duck = GetDuckByItsType(duckType);
            if (duck != null)
            {
                duck.PerformFlyBehavior();
                duck.PerformQuackBehavior();
            }

            Console.WriteLine("Thanks for using SimUDuck Simulator. We wish you a good day.");
        }

        private static Duck GetDuckByItsType(int selectedType)
        {
            switch (selectedType)
            {
                case 1:
                    return new MallardDuck();
                case 2:
                    return new RedheadDuck();
                case 3:
                    return new DecoyDuck();
                case 4:
                    return new RubberDuck();
                default:
                    return null;
            }
        }
    }
}
