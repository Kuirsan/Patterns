using System;
using System.Collections.Generic;
using System.Text;

namespace composePatterns
{
    public class DuckCall : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Kwak");
        }
    }
}
