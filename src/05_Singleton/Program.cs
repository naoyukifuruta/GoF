using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start.");

            Singleton obj1 = Singleton.GetInstance();
            Singleton obj2 = Singleton.GetInstance();

            if (obj1 == obj2)
            {
                Console.WriteLine("Same Instances.");
            }

            Console.WriteLine("End.");
        }
    }
}
