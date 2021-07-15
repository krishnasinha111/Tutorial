using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    public sealed class SingletonStaticReadonly
    {
        private static readonly SingletonStaticReadonly instance = new SingletonStaticReadonly();
        
        public static void Test()
        {
            Console.WriteLine("Test Method is called.");
        }

        //static SingletonStaticReadonly()
        //{
        //    Console.WriteLine("SingletonStaticReadonly Static constructor is called.");
        //}
        private SingletonStaticReadonly()
        {
            Console.WriteLine("SingletonStaticReadonly private constructor is called.");
        }

        // Object instantiation using Static Method
        public static SingletonStaticReadonly GetInstance()
        {
            return instance;
        }

        // Object instantiation using Static Property
        public static SingletonStaticReadonly Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
