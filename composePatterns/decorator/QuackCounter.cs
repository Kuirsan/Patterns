using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns
{
    public class QuackCounter : IQuackable
    {
        private IQuackable _duck;
        private static int _numberOfQuacks;

        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
        }
        public void Quack()
        {
            _duck.Quack();
            _numberOfQuacks++;
        }
        public static int GetQuacks()
        {
            return _numberOfQuacks;
        }
    }
}
