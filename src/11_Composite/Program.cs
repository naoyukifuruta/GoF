using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making root entries...");

            var root = new Directory("root");
            var dir1 = new Directory("dir1");
            var dir2 = new Directory("dir2");
            var dir3 = new Directory("dir3");

            var file1 = new File("file1");
            var file2 = new File("file2");
            var file3 = new File("file3");
            var file4 = new File("file4");

            root.AddEntry(dir1);
            root.AddEntry(dir2);
            dir2.AddEntry(dir3);

            root.AddEntry(file1);
            root.AddEntry(file2);
            dir2.AddEntry(file3);
            dir3.AddEntry(file4);

            root.Output(0);
        }
    }
}
