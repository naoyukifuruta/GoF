using Factory;

namespace TableFactory
{
    public class TableFactory : Factory.Factory
    {
        public override Link CreateLink(string caption, string url)
        {
            return new TableLink(caption, url);
        }

        public override Tray CreateTray(string caption)
        {
            return new TableTray(caption);
        }

        public override Page CreatePage(string title, string author)
        {
            return new TablePage(title, author);
        }
    }
}
