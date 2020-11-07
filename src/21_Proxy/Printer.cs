using System;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    public class Printer : IPrintable
    {
        private string _name;

        public Printer()
        {
            HeavyJob("Printerのインスタンスを生成中");
        }

        public Printer(string name)
        {
            _name = name;
            HeavyJob($"Printerのインスタンス({_name})を生成中");
        }

        public void SetPrinterName(string name)
        {
            _name = name;
        }

        public string GetPrinterName()
        {
            return _name;
        }

        public void Print(string str)
        {
            Console.WriteLine($"=== {_name} ===");
            Console.WriteLine(str);
        }

        private void HeavyJob(string msg)
        {
            Console.Write(msg);

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Task.Delay(1000);
                }
                catch (ThreadInterruptedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Write(".");
            }
            Console.WriteLine("完了しました。");
        }
    }
}
