using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns.abstractFactory
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable createMallardDuck();
        public abstract IQuackable createRedHeadDuck();
        public abstract IQuackable createduckCall();
        public abstract IQuackable createrubberDuck();
    }
}
