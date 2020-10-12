using composePatterns.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns
{
    public interface IQuackable: IQuackObservable
    {
        public void Quack();
    }
}
