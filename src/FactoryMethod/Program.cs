
using Framework;
using IDCard;

namespace FactoryMethod
{
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