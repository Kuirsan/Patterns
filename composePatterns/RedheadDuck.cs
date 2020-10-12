using composePatterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns
{
    public class RedheadDuck : IQuackable
    {
        private Observable _observable;
        public RedheadDuck()
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
