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

        
        public static void Test()
        {
            Console.WriteLine("Test method is called.");
        }

        // **********************************************************************************
        // Single using Static Method
        // **********************************************************************************
        public static SingletonLazy GetInstance() 
        {  
            return lazy.Value;  
        }


        // **********************************************************************************
        // Single using Static Property
        // **********************************************************************************
        public static SingletonLazy Instance 
        { 
            get 
            {
                return lazy.Value; 
            } 
        }

        private SingletonLazy()
        {
            Console.WriteLine("Private constructor of Lazy Singleton is called.");
        }
    }
}
