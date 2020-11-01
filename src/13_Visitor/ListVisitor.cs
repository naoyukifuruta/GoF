using System;

namespace Visitor
{
    public class ListVisitor : Visitor
    {
        private string currentdir = "";

        public override void Visit(File file)
        {
            Console.WriteLine(currentdir + "/" + file);
        }

        public override void Visit(Directory directory)
        {
            Console.WriteLine(currentdir + "/" + directory);
            string savedir = currentdir;
            currentdir = currentdir + "/" + directory.GetName();
            var it = directory.GetEnumerator();

            while (it.MoveNext())
            {
                Entry entry = (Entry)it.Current;
                entry.Accept(this);
            }
            currentdir = savedir;
        }
    }
}
