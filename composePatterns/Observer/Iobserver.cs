using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns.Observer
{
    public interface IObserver
    {
        public void update(IQuackObservable duck);
    }
}
