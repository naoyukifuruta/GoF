using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Usage();
                Environment.Exit(0);
            }

            if (args[0].Equals("plain"))
            {
                TextBuilder textbuilder = new TextBuilder();
                Director director = new Director(textbuilder);
                director.Construct();
                string result = textbuilder.Result;
                Console.WriteLine(result);
            }
            else if (args[0].Equals("html"))
            {
                HTMLBuilder htmlbuilder = new HTMLBuilder();
                Director director = new Director(htmlbuilder);
                director.Construct();
                string filename = htmlbuilder.Filename;
                Console.WriteLine(filename + "が作成されました。");
            }
            else
            {
                Usage();
                Environment.Exit(0);
            }
        }

        private static void Usage()
        {
            Console.WriteLine("Usage: C# Main plain  プレーンテキストで文書作成");
            Console.WriteLine("Usage: C# Main html   htmlファイルで文書作成");
        }
    }
}
