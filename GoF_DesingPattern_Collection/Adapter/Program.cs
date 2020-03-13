namespace Adapter
{
    class Program
    {
        static void Main()
        {
            Print print = new PrintBanner("Hello");
            print.PrintWeak();
            print.PrintStrong();
        }
    }
}
