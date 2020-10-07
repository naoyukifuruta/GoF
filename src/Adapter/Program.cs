namespace Adapter
{
    class Program
    {
        static void Main()
        {
            // クラスによるAdapterパターン
            {
                ClassAdapter.IPrint p = new ClassAdapter.PrintBanner("Hello");
                p.PrintWeak();
                p.PrintStrong();
            }

            // オブジェクトによるAdapterパターン
            {
                ObjectAdapter.BasePrint p = new ObjectAdapter.PrintBanner("Hello");
                p.PrintWeak();
                p.PrintStrong();
            }
        }
    }
}
