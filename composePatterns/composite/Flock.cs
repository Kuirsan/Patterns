using composePatterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns.composite
{
    public class Flock : IQuackable
    {
        private Observable _observable;
        private List<IQuackable> _quackers = new List<IQuackable>();

        public Flock()
        {
            _observable = new Observable(this);
        }
        public void Add(IQuackable quackable)
        {
            _quackers.Add(quackable);
            //RegisterOserver(quackable);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }

        public void Quack()
        {
            IEnumerator<IQuackable> iterator = _quackers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IQuackable quacker = (IQuackable)iterator.Current;
                quacker.Quack();
            }
        }

        public void RegisterOserver(IQuackObservable observer)
        {
            //_observable.RegisterOserver(observer);
            IEnumerator<IQuackable> iterator = _quackers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IQuackable quacker = (IQuackable)iterator.Current;
                quacker.RegisterOserver(observer);
            }
        }
    }
}
