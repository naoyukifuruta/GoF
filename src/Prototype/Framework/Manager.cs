using System.Collections.Generic;

namespace Framework
{
    public class Manager
    {
        private Dictionary<string, Product> showcase = new Dictionary<string, Product>();

        public void Register(string name, Product proto)
        {
            showcase.Add(name, proto);
        }

        public Product Create(string protoname)
        {
            Product p = showcase[protoname];
            return p.CreateClone();
        }
    }
}
