using composePatterns.abstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns.Factory
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable createduckCall()
        {
            return new DuckCall();
        }

        public override IQuackable createMallardDuck()
        {
            return new MallardDuck();
        }

        public override IQuackable createRedHeadDuck()
        {
            return new RedheadDuck();
        }

        public override IQuackable createrubberDuck()
        {
            return new RubberDuck();
        }
    }
}
