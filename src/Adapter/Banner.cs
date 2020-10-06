using System;

namespace Adapter
{
    public class Banner
    {
        private string _string;

        public Banner(string sstring)
        {
            this._string = sstring;
        }

        public void ShowWithParen()
        {
            Console.WriteLine("(" + _string + ")");
        }

        public void ShowWithAster()
        {
            Console.WriteLine("*" + _string + "*");
        }
    }
}
