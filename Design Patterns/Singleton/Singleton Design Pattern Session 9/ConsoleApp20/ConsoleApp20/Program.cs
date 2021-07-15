using System;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingletonStaticReadonly.Test();

            Parallel.Invoke(
                createFirstObject,
                createSecondObject,
                createThirdObject
                );

            createFirstObject();
            createSecondObject();
            createThirdObject();

            //SingletonWithoutSealed.ChildSingleton c1 = new SingletonWithoutSealed.ChildSingleton();
            //SingletonWithoutSealed.ChildSingleton c2 = new SingletonWithoutSealed.ChildSingleton();
            //SingletonWithoutSealed.ChildSingleton c3 = new SingletonWithoutSealed.ChildSingleton();
        }

        private static void createFirstObject()
        {
            // *************************************************************************************
            // Singleton with Single Lock            
            // *************************************************************************************
            //SingletonWithLock s1 = SingletonWithLock.GetInstance();


            // *************************************************************************************
            // Singleton with Lazy Keyword          
            // *************************************************************************************
            //SingletonLazy s1 = SingletonLazy.GetInstance();

            // *************************************************************************************
            // Singleton with Static readonly method      
            // *************************************************************************************
            SingletonStaticReadonly s1 = SingletonStaticReadonly.GetInstance();

            // *************************************************************************************
            // Singleton with Static readonly - Using property        
            // *************************************************************************************
            //SingletonStaticReadonly s1 = SingletonStaticReadonly.Instance;

            Console.WriteLine("s1 Object got created.");
        }

        private static void createSecondObject()
        {
            // *************************************************************************************
            // Singleton with Single Lock            
            // *************************************************************************************
            //SingletonWithLock s2 = SingletonWithLock.GetInstance();

            // *************************************************************************************
            // Singleton with Lazy Keyword          
            // *************************************************************************************
            //SingletonLazy s2 = SingletonLazy.GetInstance();

            // *************************************************************************************
            // Singleton with Static readonly        
            // *************************************************************************************
            SingletonStaticReadonly s2 = SingletonStaticReadonly.GetInstance();

            // *************************************************************************************
            // Singleton with Static readonly - Using property        
            // *************************************************************************************
            //SingletonStaticReadonly s2 = SingletonStaticReadonly.Instance;

            Console.WriteLine("s2 Object got created.");
        }

        private static void createThirdObject()
        {
            // *************************************************************************************
            // Singleton with Single Lock            
            // *************************************************************************************
            //SingletonWithLock s3 = SingletonWithLock.GetInstance();

            // *************************************************************************************
            // Singleton with Lazy Keyword          
            // *************************************************************************************
            //SingletonLazy s3 = SingletonLazy.GetInstance();

            // *************************************************************************************
            // Singleton with Static readonly        
            // *************************************************************************************
            SingletonStaticReadonly s3 = SingletonStaticReadonly.GetInstance();

            // *************************************************************************************
            // Singleton with Static readonly - Using property        
            // *************************************************************************************
            //SingletonStaticReadonly s3 = SingletonStaticReadonly.Instance;

            Console.WriteLine("s3 Object got created.");
        }
    }
}