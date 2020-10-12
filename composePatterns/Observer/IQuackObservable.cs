using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns.Observer
{
    public interface IQuackObservable
    {
        public void RegisterOserver(IQuackObservable observer);
        public void NotifyObservers();

        public void update(IQuackObservable duck)
        {
            Console.WriteLine($"Quacklogist: {duck} just quacked");
        }
    }
}
