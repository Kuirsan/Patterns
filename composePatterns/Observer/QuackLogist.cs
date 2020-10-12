using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns.Observer
{
    public class QuackLogist : IQuackObservable
    {
        public void NotifyObservers()
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(IQuackObservable duck)
        {
            Console.WriteLine($"Quacklogist: {duck} just quacked");
        }

        public void RegisterOserver(IQuackObservable observer)
        {
            throw new NotImplementedException();
        }

        public void update(IQuackObservable duck)
        {
            Console.WriteLine($"Quacklogist: {duck} just quacked");
        }
    }
}
