using System.Collections.Generic;
using System.Text;
using Factory;

namespace TableFactory
{
    public class TableTray : Tray
    {
        public TableTray(string caption) : base(caption) { }

        public override string MakeHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<td>");
            sb.Append("<table width=\"100%\" border=\"1\"><tr>");
            sb.Append($"<td bgcolor=\"#cccccc\" align=\"center\" colspan=\"{tray.Count}\"<b>{caption}</b></td>");
            sb.Append("</tr>\n");
            sb.Append("<tr>\n");
            IEnumerator<Item> e = tray.GetEnumerator();
            while (e.MoveNext())
            {
                sb.Append(e.Current.MakeHTML());
            }
            sb.Append("<tr></table>");
            sb.Append("</tr>");
            return sb.ToString();
        }
    }
}
