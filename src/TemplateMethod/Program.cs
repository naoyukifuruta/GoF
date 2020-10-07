using System;
using System.Text;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello, Wirld");
            AbstractDisplay d3 = new StringDisplay("こんにちは！");
            d1.Display();
            d2.Display();
            d3.Display();
        }
    }

    public abstract class AbstractDisplay
    {
        public abstract void Open();
        public abstract void Print();
        public abstract void Close();

        public void Display()
        {
            Open();
            for (int i = 0; i < 5; i++)
            {
                Print();
            }
            Close();
        }
    }

    public class CharDisplay : AbstractDisplay
    {
        private char _ch;

        public CharDisplay(char ch)
        {
            _ch = ch;
        }

        public override void Open()
        {
            Console.Write("<<");
        }

        public override void Print()
        {
            Console.Write(_ch);
        }

        public override void Close()
        {
            Console.WriteLine(">>");
        }
    }

    public class StringDisplay : AbstractDisplay
    {
        private string _str;

        private int _width;

        public StringDisplay(string str)
        {
            _str = str;
            _width = _str.Length;
        }

        public override void Open()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine($"|{_str}|");
        }

        public override void Close()
        {
            PrintLine();
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < _width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
