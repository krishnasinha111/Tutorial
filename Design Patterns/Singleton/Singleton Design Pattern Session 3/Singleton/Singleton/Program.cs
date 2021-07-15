using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
               createFirstObject,
               createSecondObject,
               createThirdObject);           
        }

        private static void createFirstObject()
        {
            Singleton s1 = Singleton.GetInstance();
            Console.WriteLine("s1 Object is created.");
        }

        private static void createSecondObject()
        {
            Singleton s2 = Singleton.GetInstance();
            Console.WriteLine("s2 Object is created.");
        }

        private static void createThirdObject()
        {
            Singleton s3 = Singleton.GetInstance();
            Console.WriteLine("s3 Object is created.");
        }

    }

    public class Singleton
    {
        private static object lockobject = new object();
        private static Singleton instance;
        private Singleton()
        {
            Console.WriteLine("Private constructor is called.");
        }

        public static Singleton GetInstance()
        {
            lock (lockobject)
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
            }
            return instance;
        }
    }
}
