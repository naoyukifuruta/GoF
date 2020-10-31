using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Factory
{
    public abstract class Page
    {
        protected string title;
        protected string author;
        protected List<Item> content = new List<Item>();

        public Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void Add(Item item)
        {
            this.content.Add(item);
        }

        public void Output()
        {
            try
            {
                string filename = title + ".html";
                using (StreamWriter writer = new StreamWriter(filename, false, Encoding.UTF8))
                {
                    writer.Write(this.MakeHTML());
                }
                Console.WriteLine($"{filename}を作成しました。");
            }
            catch (IOException e)
            {
                Console.Error.WriteLine(e);
            }
        }

        public abstract string MakeHTML();
    }
}
