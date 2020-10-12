using composePatterns;
using composePatterns.abstractFactory;
using composePatterns.composite;
using composePatterns.Factory;
using composePatterns.Observer;
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

            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(mallardDuck);
            flockOfDucks.Add(redheadDuck);
            flockOfDucks.Add(duckCall);
            flockOfDucks.Add(rubberDuck);
            flockOfDucks.Add(gooseDuck);

            Flock flockOfMallards = new Flock();
            IQuackable mallardOne = duckFactory.createMallardDuck();
            IQuackable mallardTwo = duckFactory.createMallardDuck();
            IQuackable mallardThree = duckFactory.createMallardDuck();
            IQuackable mallardFour = duckFactory.createMallardDuck();

            flockOfMallards.Add(mallardFour);
            flockOfMallards.Add(mallardThree);
            flockOfMallards.Add(mallardTwo);
            flockOfMallards.Add(mallardOne);


            flockOfDucks.Add(flockOfMallards);

            QuackLogist quackLogist = new QuackLogist();
            flockOfDucks.RegisterOserver(quackLogist);


            Console.WriteLine("Duck simulator");
            simulate(flockOfDucks);

            Console.WriteLine("Mallard flock sim");
            simulate(flockOfMallards);

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
