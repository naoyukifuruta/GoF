using System;

namespace Bridge
{
    public class StringDisplayImpl : DisplayImpl
    {
        private string str;
        private int width;

        public StringDisplayImpl(string str)
        {
            this.str = str;
            this.width = str.Length;
        }

        public override void RawOpen()
        {
            PrintLine();
        }

        public override void RawPrint()
        {
            Console.WriteLine($"|{str}|");
        }

        public override void RawClose()
        {
            PrintLine();
        }

        public void PrintLine()
        {
            Console.Write("+");

            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("+");
        }
    }
}
