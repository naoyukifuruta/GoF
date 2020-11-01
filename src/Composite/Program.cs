using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Making root entries...");

                var rootdir = new Directory("root");
                var bindir = new Directory("bin");

                rootdir.Add(bindir);

                rootdir.PrintList();
            }
            catch (FileTreatmentException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
