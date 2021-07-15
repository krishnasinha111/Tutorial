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

        }

        private static void createFirstObject()
        {
            SingletonDoubleCheckLock s1 = SingletonDoubleCheckLock.Instance;
            Console.WriteLine("s1 Object got created.");
        }

        private static void createSecondObject()
        {
            SingletonDoubleCheckLock s2 = SingletonDoubleCheckLock.Instance;
             Console.WriteLine("s2 Object got created.");
        }

        private static void createThirdObject()
        {
            SingletonDoubleCheckLock s3 = SingletonDoubleCheckLock.Instance;
            Console.WriteLine("s3 Object got created.");
        }
    }
}