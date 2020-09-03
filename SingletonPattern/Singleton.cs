using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton singletonInstance;
        private static readonly object padlock = new object();

        private Singleton() { }

        public static Singleton getInstance()
        {
            if (singletonInstance == null)
            {
                lock (padlock)
                {
                    if (singletonInstance == null)
                    {
                        singletonInstance = new Singleton();
                    }
                }
            }
            return singletonInstance;
        }
    }
}
