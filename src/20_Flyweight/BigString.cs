using System;

namespace Flyweight
{
    public class BigString
    {
        private BigChar[] bigchars;

        public BigString(String str)
        {
            bigchars = new BigChar[str.Length];
            BigCharFactory bigCharFactory = BigCharFactory.getInstance();

            for (int i = 0; i < bigchars.Length; i++)
            {
                bigchars[i] = bigCharFactory.getBigChar(str[i]);
            }
        }

        public void print()
        {
            for (int i = 0; i < bigchars.Length; i++)
            {
                bigchars[i].print();
            }
        }
    }
}
