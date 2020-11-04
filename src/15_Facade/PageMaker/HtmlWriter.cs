using System;
using System.IO;

namespace Facade.PageMaker
{
    public class HtmlWriter : IDisposable
    {
        public StreamWriter _writer { get; set; }

        public HtmlWriter(StreamWriter writer)
        {
            this._writer = writer;
        }

        public void WriteTitle(string title)
        {
            _writer.Write("<html>");
            _writer.Write("<head>");
            _writer.Write("<title>" + title + "</title>");
            _writer.Write("</head>");
            _writer.Write("<body>\n");
            _writer.Write("<h1>" + title + "<h1>");
        }

        public void WriteParagraph(string msg)
        {
            _writer.Write("<p>" + msg + "</p>\n");
        }

        public void WriteLink(string href, string caption)
        {
            _writer.Write("<a href=\"" + href + "\">" + caption + "</p>\n");
        }

        public void WriteMailTo(string mailAddr, string userName)
        {
            WriteLink(("mailto:" + mailAddr), userName);
        }

        public void Close()
        {
            _writer.Write("</body>");
            _writer.Write("</html>\n");
        }

        public void Dispose()
        {
            _writer.Dispose();
        }
    }
}
