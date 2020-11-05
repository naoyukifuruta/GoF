using System;
using Memento.Game;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamer = new Gamer(100);
            var memento = gamer.CreateMemento();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"==== {i}");
                Console.WriteLine($"現状 {gamer}");

                gamer.Bet();

                Console.WriteLine($"所持金は {gamer.Money}円になりました");

                if (gamer.Money > memento.Money)
                {
                    Console.WriteLine($"    （だいぶ増えたので、現在の状態を保存しておこう）");
                    memento = gamer.CreateMemento();
                }
                else if (gamer.Money < memento.Money / 2)
                {
                    Console.WriteLine($"    （だいぶ減ったので、以前の状態に復帰しよう）");
                    gamer.RestoreMemento(memento);
                }
            }
        }
    }
}
