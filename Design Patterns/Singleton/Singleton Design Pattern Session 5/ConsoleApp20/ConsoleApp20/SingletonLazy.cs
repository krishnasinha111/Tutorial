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

        // **********************************************************************************
        // Single using Static Property
        // **********************************************************************************
        //public static Singleton Instance { get { return lazy.Value; } }


        // **********************************************************************************
        // Single using Static Method
        // **********************************************************************************
        public static SingletonLazy GetInstance() {  return lazy.Value;  }

        private SingletonLazy()
        {
            Console.WriteLine("Private constructor of Lazy Singleton is called.");
        }
    }
}
