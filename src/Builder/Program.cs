﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void Usage()
        {
            Console.WriteLine("Usage: C# Main plain  プレーンテキストで文書作成");
            Console.WriteLine("Usage: C# Main html   htmlファイルで文書作成");
        }
    }

    public abstract class Builder
    {
        public abstract void MakeTitle(string title);
        public abstract void MakeString(string str);
        public abstract void MakeItems(string[] items);
        public abstract void Close();
    }

    public class Director
    {
        private Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            this.builder.MakeTitle("Greeting");
            this.builder.MakeString("朝から昼にかけて");
            this.builder.MakeItems(new string[]
            {
                "おはようございます。",
                "こんにちは。",
            });
            this.builder.MakeString("夜に");
            this.builder.MakeItems(new string[]
            {
                "こんばんは。",
                "おやすみなさい。",
                "さようなら。",
            });
            this.builder.Close();
        }
    }

    public class TextBuilder : Builder
    {
        private StringBuilder sb = new StringBuilder();

        public string Result
        {
            get { return sb.ToString(); }
        }

        public override void MakeTitle(string title)
        {
            sb.Append("==============================\n");
            sb.Append($"『{title}』");
            sb.Append("\n");
        }

        public override void MakeString(string str)
        {
            sb.Append($"■{str}\n");
            sb.Append("\n");
        }

        public override void MakeItems(string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                sb.Append($"　・{items[i]}\n");
            }
            sb.Append("\n");
        }

        public override void Close()
        {
            sb.Append("==============================\n");
        }
    }

    public class HTMLBuilder : Builder
    {
        public string Filename { get; private set; }

        private System.IO.StreamWriter writer;

        public override void MakeTitle(string title)
        {
            this.Filename = title + ".html";
            using (System.IO.StreamWriter writer = System.IO.File.CreateText(title))
            {
                this.writer = writer;
                writer.WriteLine($"<html><head><title>{title}</title></head><body>");
                writer.WriteLine($"<h1>{title}</h1>");
            }
        }

        public override void MakeString(string str)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.Filename, true, Encoding.GetEncoding("utf-8")))
            {
                writer.WriteLine($"<p>{str}</p>");
            }
        }

        public override void MakeItems(string[] items)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.Filename, true, Encoding.GetEncoding("utf-8")))
            {
                writer.WriteLine("<ul>");
                for (int i = 0; i < items.Length; i++)
                {
                    writer.WriteLine($"<li>{items[i]}</li>");
                }
                writer.WriteLine("</ul>");
            }
        }

        public override void Close()
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.Filename, true, Encoding.GetEncoding("utf-8")))
            {
                writer.WriteLine("</body></html>");
            }
        }
    }
}
