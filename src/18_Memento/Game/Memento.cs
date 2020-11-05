using System.Collections.Generic;

namespace Memento.Game
{
    public class Memento
    {
        private IList<string> _fruits = new List<string>();
        public int Money { get; private set; }
        public IList<string> Fruits
        {
            get
            {
                return new List<string>(_fruits);
            }
        }

        public Memento(int money)
        {
            Money = money;
        }

        public void AddFruit(string fruit)
        {
            _fruits.Add(fruit);
        }
    }
}
