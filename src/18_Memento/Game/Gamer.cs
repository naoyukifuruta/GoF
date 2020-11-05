using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.Game
{
    public class Gamer
    {
        private static readonly string[] _fruitNames = new string[]
        {
            "リンゴ",
            "ぶどう",
            "バナナ",
            "みかん"
        };

        private Random _randam = new Random();
        private IList<string> _fruits = new List<string>();

        public int Money { get; private set; }

        public Gamer(int money)
        {
            Money = money;
        }

        public void Bet()
        {
            int dice = _randam.Next(1, 6);
            switch (dice)
            {
                case 1:
                    Money += 100;
                    Console.WriteLine("所持金が増えました。");
                    break;
                case 2:
                    Money /= 2;
                    Console.WriteLine("所持金が半分になりました。");
                    break;
                case 6:
                    string fruit = GetFruit();
                    Console.WriteLine("フルーツをもらいました。");
                    _fruits.Add(fruit);
                    break;
                default:
                    Console.WriteLine("何も起こりませんでした。");
                    break;
            }
        }

        public Memento CreateMemento()
        {
            Memento memento = new Memento(Money);
            _fruits.Where(fruit => fruit.StartsWith("おいしい")).ToList().
                ForEach(deliciousFruit => memento.AddFruit(deliciousFruit));
            return memento;
        }

        public void RestoreMemento(Memento memento)
        {
            Money = memento.Money;
            _fruits = memento.Fruits;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            foreach (var fruit in _fruits)
            {
                stringBuilder.Append(fruit + ",");
            }

            return $"[money = {Money}, fruits = {stringBuilder}]";
        }

        public string GetFruit()
        {
            string prefix = _randam.Next(2) == 1 ? "おいしい" : string.Empty;
            return prefix + _fruitNames[_randam.Next(_fruitNames.Length - 1)];
        }
    }
}
