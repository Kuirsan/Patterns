using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns
{
    public class RedheadDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
