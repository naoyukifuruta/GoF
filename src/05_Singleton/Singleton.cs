using System;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton singleton = new Singleton();

        private Singleton()
        {
            Console.WriteLine("Create Instance.");
        }

        public static Singleton GetInstance()
        {
            return singleton;
        }
    }
}
