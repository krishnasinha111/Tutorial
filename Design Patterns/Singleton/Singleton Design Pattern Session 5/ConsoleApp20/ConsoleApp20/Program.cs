using System;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
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
            SingletonWithoutSealed s1 = SingletonWithoutSealed.GetInstance();
            Console.WriteLine("s1 Object got created.");
        }

        private static void createSecondObject()
        {
            SingletonWithoutSealed s2 = SingletonWithoutSealed.GetInstance();
            Console.WriteLine("s2 Object got created.");
        }

        private static void createThirdObject()
        {
            SingletonWithoutSealed s3 = SingletonWithoutSealed.GetInstance();
            Console.WriteLine("s3 Object got created.");
        }
    }
}