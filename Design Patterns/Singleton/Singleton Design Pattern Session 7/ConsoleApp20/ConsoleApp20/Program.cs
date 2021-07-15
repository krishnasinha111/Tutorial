using System;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonLazy.Test();
            SingletonLazy.Test();
            SingletonLazy.Test();

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
            SingletonLazy s1 = SingletonLazy.GetInstance();
            Console.WriteLine("s1 Object got created.");
        }

        private static void createSecondObject()
        {
            SingletonLazy s2 = SingletonLazy.GetInstance();
            Console.WriteLine("s2 Object got created.");
        }

        private static void createThirdObject()
        {
            SingletonLazy s3 = SingletonLazy.GetInstance();
            Console.WriteLine("s3 Object got created.");
        }
    }
}