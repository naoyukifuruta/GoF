namespace Adapter
{
    public class PrintBanner : Print
    {
        private Banner _banner;

        public PrintBanner(string sstring)
        {
            this._banner = new Banner(sstring);
        }

        public override void PrintWeak()
        {
            _banner.ShowWithParen();
        }

        public override void PrintStrong()
        {
            _banner.ShowWithAster();
        }
    }
}
