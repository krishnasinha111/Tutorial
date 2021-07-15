using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            Singleton s3 = Singleton.GetInstance();

            if (s1 == s2 && s1 == s3 && s2 == s3)
            {
                Console.WriteLine("All the objects are same.");
            }
            else
            {
                Console.WriteLine("Not all the objects are same.");
            }

        }
           
    }

    public class Singleton
    {

        private static Singleton instance;
        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}
