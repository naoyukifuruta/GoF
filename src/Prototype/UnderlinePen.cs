using System;
using Framework;

namespace Prototype
{
    public class UnderlinePen : Product
    {
        private char ulchar;

        public UnderlinePen(char ulchar)
        {
            this.ulchar = ulchar;
        }

        public void Use(string s)
        {
            int length = s.Length;

            Console.WriteLine($"\"{s}\"");
            Console.Write(" ");

            for (int i = 0; i < length; i++)
            {
                Console.Write(ulchar);
            }
            Console.WriteLine("");
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Product CreateClone()
        {
            return (Product)this.Clone();
        }
    }
}
