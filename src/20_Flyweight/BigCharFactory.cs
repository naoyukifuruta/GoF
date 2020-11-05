using System;
using System.Collections;

namespace Flyweight
{
    public class BigCharFactory
    {
        private Hashtable pool = new Hashtable();

        private static BigCharFactory bigCharFactory = new BigCharFactory();

        private BigCharFactory()
        {
        }

        public static BigCharFactory getInstance()
        {
            return bigCharFactory;
        }

        public BigChar getBigChar(char charname)
        {
            BigChar bigChar = (BigChar)pool["" + charname];

            if (bigChar == null)
            {
                bigChar = new BigChar(charname);
                pool.Add("" + charname, bigChar);
            }
            return bigChar;
        }
    }
}
