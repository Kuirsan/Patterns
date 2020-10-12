using composePatterns.abstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns.Factory
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable createduckCall()
        {
            return new QuackCounter(new DuckCall());
        }

        public override IQuackable createMallardDuck()
        {
            return new QuackCounter(new MallardDuck());
        }

        public override IQuackable createRedHeadDuck()
        {
            return new QuackCounter(new RedheadDuck());
        }

        public override IQuackable createrubberDuck()
        {
            return new QuackCounter(new RubberDuck());
        }
    }
}
