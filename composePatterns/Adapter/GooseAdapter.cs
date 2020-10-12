using composePatterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns
{
    public class GooseAdapter : IQuackable
    {
        private Observable _observable;

        private Goose _goose;
        public GooseAdapter(Goose goose)
        {
            _goose = goose;
            _observable = new Observable(this);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public void Quack()
        {
            _goose.honk();
            NotifyObservers();
        }

        public void RegisterOserver(IQuackObservable observer)
        {
            _observable.RegisterOserver(observer);
        }
    }
}
