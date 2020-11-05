using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class DigitObserver : IObserver<NumberGenerator>
    {
        private NumberGenerator generator;

        public DigitObserver(NumberGenerator generator)
        {
            this.generator = generator;
        }

        void IObserver<NumberGenerator>.OnCompleted()
        {
            Console.WriteLine("DigitObserver:" + generator.GetNumber().ToString());
        }

        void IObserver<NumberGenerator>.OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        void IObserver<NumberGenerator>.OnNext(NumberGenerator value)
        {
            throw new NotImplementedException();
        }
    }
}
