using System;

// 便宜上1ファイルにすべてのクラスを実装
namespace ClassAdapter
{
    public class Banner
    {
        private string _str;

        public Banner(string str)
        {
            _str = str;
        }

        public void ShowWithPattern()
        {
            Console.WriteLine($"({_str})");
        }

        public void ShowWithAster()
        {
            Console.WriteLine($"*{_str}*");
        }
    }

    public interface IPrint
    {
        void PrintWeak();
        void PrintStrong();
    }

    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string str) : base(str) { }

        public void PrintWeak()
        {
            ShowWithPattern();
        }

        public void PrintStrong()
        {
            ShowWithAster();
        }
    }
}