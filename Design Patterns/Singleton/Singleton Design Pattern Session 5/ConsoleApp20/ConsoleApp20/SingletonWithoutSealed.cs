using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    public sealed class SingletonWithoutSealed
    {
        private static object lockobject = new object();
        private static SingletonWithoutSealed instance = null;
        private SingletonWithoutSealed()
        {
            Console.WriteLine("Private constructor is called.");
        }

        public static SingletonWithoutSealed GetInstance()
        {
            if (instance == null)
            {
                lock (lockobject)
                {
                    if (instance == null)
                    {
                        instance = new SingletonWithoutSealed();
                    }
                }
            }
            return instance;
        }
    }
}
