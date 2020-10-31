using System.Collections.Generic;
using System.Text;
using Factory;

namespace TableFactory
{
    public class TablePage : Page
    {
        public TablePage(string title, string author) : base(title, author) { }

        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"<html><head><title>{title}</title></head>\n");
            sb.Append("<body>\n");
            sb.Append($"<h1>{title}</h1>\n");
            sb.Append("<table width=\"80%\" border=\"3\">\n");
            IEnumerator<Item> e = content.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append($"<tr>{e.Current.MakeHTML()}</tr>");
            }
            sb.Append("</table>\n");
            sb.Append($"<hr><address>{author}</address>");
            sb.Append("</body></html>\n");
            return sb.ToString();
        }
    }
}
