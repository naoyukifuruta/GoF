using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintable iPrintable = new PrinterProxy("佐藤");
            Console.WriteLine($"名前は現在{iPrintable.GetPrinterName()}です。");

            iPrintable.SetPrinterName("田中");
            Console.WriteLine($"名前は現在{iPrintable.GetPrinterName()}です。");
            iPrintable.Print("Hello World!");
        }
    }
}
