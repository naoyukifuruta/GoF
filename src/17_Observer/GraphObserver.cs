using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class GraphObserver : IObserver<NumberGenerator>
    {
        private NumberGenerator generator;

        public GraphObserver(NumberGenerator generator)
        {
            this.generator = generator;
        }

        void IObserver<NumberGenerator>.OnCompleted()
        {
            int Count = 0;
            Count = generator.GetNumber();

            Console.Write("GraphObserver:");

            for (int i = 0; i < Count; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
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
