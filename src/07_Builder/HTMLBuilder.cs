using System.Text;

namespace Builder
{
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
