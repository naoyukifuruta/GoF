using System;

namespace Composite
{
    public class File : IEntry
    {
        private string _name = null;

        public File(string someName)
        {
            _name = someName;
        }

        public void Output(int someDepth)
        {
            for (int i = 0; i < someDepth; i++)
            {
                Console.Write("    ");
            }

            Console.WriteLine("{0} : {1}", this.GetType().ToString(), _name);
        }
    }
}
