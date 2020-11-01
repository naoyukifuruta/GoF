using System;
using System.Collections.Generic;

namespace Composite
{
    public class Directory : IEntry
    {
        private string _name = null;
        private List<IEntry> _entries = new List<IEntry>();

        public Directory(string someName)
        {
            _name = someName;
        }

        public void AddEntry(IEntry someEntry)
        {
            _entries.Add(someEntry);
        }

        public void Output(int someDepth)
        {
            for (int i = 0; i < someDepth; i++)
            {
                Console.Write("    ");
            }

            Console.WriteLine("{0} : {1}", this.GetType().ToString(), _name);

            foreach (var item in _entries)
            {
                item.Output(someDepth + 1);
            }
        }
    }
}
