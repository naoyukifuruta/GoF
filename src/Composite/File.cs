﻿using System;

namespace Composite
{
    public class File : Entry
    {
        private string _name;
        private int _size;

        public File(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            return _size;
        }

        protected override void PrintList(string prefix)
        {
            Console.WriteLine(prefix + "/" + this);
        }
    }
}
