using System;

namespace Observer
{
    public class RandamNumberGenerator : NumberGenerator
    {
        private Random GRandam = new Random();
        private int Number = 0;

        public override int GetNumber()
        {
            return Number;
        }

        public override void Execute()
        {
            for (int i = 0; i < 20; i++)
            {
                Number = GRandam.Next(50);
                NotifyObservers();
            }
        }
    }
}
