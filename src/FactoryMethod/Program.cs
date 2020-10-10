using System;

namespace FactoryMethod
{
    using Framework;
    using IDCard;

    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new IDCardFactory();
            Product card1 = factory.Create("Yamada");
            Product card2 = factory.Create("Suzuki");
            Product card3 = factory.Create("Takahashi");

            card1.Use();
            card2.Use();
            card3.Use();
        }
    }
}

namespace Framework
{
    public abstract class Product
    {
        public abstract void Use();
    }

    public abstract class Factory
    {
        protected abstract Product CreateProduct(string owner);

        protected abstract void RegisterProduct(Product product);

        public Product Create(string owner)
        {
            Product p = CreateProduct(owner);
            RegisterProduct(p);
            return p;
        }
    }
}

namespace IDCard
{
    using System.Collections.Generic;
    using Framework;

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

    public class IDCardFactory : Factory
    {
        private List<string> Owners { get; set; } = new List<string>();

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            Owners.Add(((IDCard)product).Owner);
        }
    }
}