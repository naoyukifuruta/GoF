using System;
using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class Directory : Entry
    {
        private string _name;
        private List<Entry> _direcrtory = new List<Entry>();

        public Directory(string name)
        {
            _name = name;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            return _direcrtory.Count();
        }

        public new Entry Add(Entry entry)
        {
            _direcrtory.Add(entry);
            return this;
        }

        protected override void PrintList(string prefix)
        {
            Console.WriteLine(prefix + "/" + this);
            foreach (var entry in _direcrtory)
            {
                entry.PrintList();
                //PrintList(prefix + "/" + _name);
            }
        }
    }
}
