using composePatterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns
{
    public class MallardDuck : IQuackable
    {
        private Observable _observable;
        public MallardDuck()
        {
            _observable = new Observable(this);
        }
        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObservers();
        }

        public void RegisterOserver(IQuackObservable observer)
        {
            _observable.RegisterOserver(observer);
        }
    }
}
