using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns.Observer
{
    public class Observable : IQuackObservable
    {
        private List<IQuackObservable> _observers = new List<IQuackObservable>();
        private IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }
        public void NotifyObservers()
        {
            IEnumerator<IQuackObservable> iterator = _observers.GetEnumerator();
            while (iterator.MoveNext())
            {
                IQuackObservable observer = (IQuackObservable)iterator.Current;
                observer.update(_duck);
            }
        }

        public void RegisterOserver(IQuackObservable observer)
        {
            _observers.Add(observer);
        }

    }
}
