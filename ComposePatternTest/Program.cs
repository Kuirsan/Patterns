using composePatterns;
using composePatterns.abstractFactory;
using composePatterns.Factory;
using System;

namespace ComposePatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            simulate(duckFactory);
        }
        public static void simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable mallardDuck = duckFactory.createMallardDuck();
            IQuackable redheadDuck = duckFactory.createRedHeadDuck();
            IQuackable duckCall = duckFactory.createduckCall();
            IQuackable rubberDuck = duckFactory.createrubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            Console.WriteLine("Duck simulator");

            simulate(mallardDuck);
            simulate(redheadDuck);
            simulate(duckCall);
            simulate(rubberDuck);
            simulate(gooseDuck);

            Console.WriteLine($"The ducks quacked {QuackCounter.GetQuacks()} times.");
        }
        public static void simulate(IQuackable duck)
        {
            duck.Quack();
        }
    }
}
