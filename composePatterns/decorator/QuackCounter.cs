using composePatterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns
{
    public class QuackCounter : IQuackable
    {
        private IQuackable _duck;
        private static int _numberOfQuacks;
        private Observable _observable;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
            _observable = new Observable(this);
        }
        public void Quack()
        {
            _duck.Quack();
            _numberOfQuacks++;
            NotifyObservers();
        }
        public static int GetQuacks()
        {
            return _numberOfQuacks;
        }

        public void RegisterOserver(IQuackObservable observer)
        {
            _observable.RegisterOserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }
}
