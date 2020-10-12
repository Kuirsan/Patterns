using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns
{
    public class MallardDuck : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
