using System;

// 便宜上1ファイルにすべてのクラスを実装
namespace ObjectAdapter
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

    public abstract class BasePrint
    {
        public abstract void PrintWeak();
        public abstract void PrintStrong();
    }

    public class PrintBanner : BasePrint
    {
        private Banner _banner;

        public PrintBanner(string str)
        {
            _banner = new Banner(str);
        }

        public override void PrintWeak()
        {
            _banner.ShowWithPattern();
        }

        public override void PrintStrong()
        {
            _banner.ShowWithAster();
        }
    }
}
