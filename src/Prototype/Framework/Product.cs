using System;

namespace Framework
{
    public interface Product : ICloneable
    {
        void Use(string s);

        Product CreateClone();
    }
}
