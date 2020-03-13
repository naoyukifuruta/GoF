using System;
namespace Iterator
{
    public interface IIterator
    {
        public abstract bool HasNext();
        public abstract Object Next();
    }
}
