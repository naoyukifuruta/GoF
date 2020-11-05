using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberGenerator generator = new RandamNumberGenerator();

            var observer1 = new DigitObserver(generator);
            var observer2 = new GraphObserver(generator);

            generator.AddObserver(observer1);
            generator.AddObserver(observer2);

            generator.Execute();
        }
    }
}
