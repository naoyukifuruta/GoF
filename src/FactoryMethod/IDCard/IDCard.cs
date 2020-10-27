using System;
using Framework;

namespace IDCard
{
    public class IDCard : Product
    {
        public string Owner { get; private set; }

        internal IDCard(string owner)
        {
            Console.WriteLine($"{owner}のカードを作ります。");
            this.Owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine($"{Owner}のカードを使います。");
        }
    }
}
