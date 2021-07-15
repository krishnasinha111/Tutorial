using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    public class SingletonWithLock
    {
        private static object lockobject = new object();
        private static SingletonWithLock instance = null;
        private SingletonWithLock()
        {
            Console.WriteLine("Private constructor is called.");
        }

        public static SingletonWithLock GetInstance()
        {
            lock (lockobject)
            {
                if (instance == null)
                {
                    instance = new SingletonWithLock();
                }
            }
            return instance;
        }
    }
}
