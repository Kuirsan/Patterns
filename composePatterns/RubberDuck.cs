using composePatterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns
{
    public class RubberDuck : IQuackable
    {
        private Observable _observable;
        public RubberDuck()
        {
            _observable = new Observable(this);
        }
        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public void Quack()
        {
            Console.WriteLine("Squeak");
            NotifyObservers();
        }

        public void RegisterOserver(IQuackObservable observer)
        {
            _observable.RegisterOserver(observer);
        }
    }
}
