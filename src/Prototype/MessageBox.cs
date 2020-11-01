using System;
using Framework;

namespace Prototype
{
    public class MessageBox : Product
    {
        private char decochar;

        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }

        public void Use(string s)
        {
            int length = s.Length;
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
            Console.WriteLine($"{decochar} {s} {decochar}");
            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
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
