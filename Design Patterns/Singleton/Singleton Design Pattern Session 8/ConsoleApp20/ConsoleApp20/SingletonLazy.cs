using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    public sealed class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy>
            lazy =
            new Lazy<SingletonLazy>
                (() => new SingletonLazy());

        //public static SingletonLazy Instance { get { return lazy.Value; } }

        public static SingletonLazy GetInstance() 
        {
            return lazy.Value;  
        }

        private SingletonLazy()
        {
            Console.WriteLine("Private constructor of Lazy Singleton is called.");
        }
    }
}
