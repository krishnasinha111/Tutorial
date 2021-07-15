using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    public class SingletonDoubleCheckLock
    {
        private static object lockobject = new object();
        private static SingletonDoubleCheckLock instance = null;
        private SingletonDoubleCheckLock()
        {
            Console.WriteLine("Private constructor is called.");
        }

        public static SingletonDoubleCheckLock GetInstance()
        {
            if (instance == null)
            {
                lock (lockobject)
                {
                    if (instance == null)
                    {
                        instance = new SingletonDoubleCheckLock();
                    }
                }
            }
            return instance;
        }
    }
}
