using System;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonStaticReadonly.Test();
            SingletonStaticReadonly.Test();
            SingletonStaticReadonly.Test();

            Parallel.Invoke(
                createFirstObject,
                createSecondObject,
                createThirdObject
                );

            createFirstObject();
            createSecondObject();
            createThirdObject();
        
        }

        private static void createFirstObject()
        {
            SingletonStaticReadonly s1 = SingletonStaticReadonly.GetInstance();
            Console.WriteLine("s1 Object got created.");
        }

        private static void createSecondObject()
        {
            SingletonStaticReadonly s2 = SingletonStaticReadonly.GetInstance();
            Console.WriteLine("s2 Object got created.");
        }

        private static void createThirdObject()
        {
            SingletonStaticReadonly s3 = SingletonStaticReadonly.GetInstance();
            Console.WriteLine("s3 Object got created.");
        }
    }
}