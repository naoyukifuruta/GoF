using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class NumberGenerator : IObservable<int>
    {
        private IList Observers = new List<IObserver<NumberGenerator>>();

        public void AddObserver(IObserver<NumberGenerator> _observer)
        {

            Observers.Add(_observer);
        }

        public void DelteteObserver(IObserver<NumberGenerator> _observer)
        {
            Observers.Remove(_observer);
        }

        public void NotifyObservers()
        {
            foreach (IObserver<NumberGenerator> _Observer in Observers)
            {
                _Observer.OnCompleted();
            }
        }

        public abstract int GetNumber();

        public abstract void Execute();

        public IDisposable Subscribe(IObserver<int> observer)
        {
            throw new NotImplementedException();
        }
    }
}
