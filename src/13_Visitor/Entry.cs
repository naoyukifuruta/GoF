using System.Collections;

namespace Visitor
{
    public abstract class Entry : IElement
    {
        public abstract string GetName();
        public abstract int GetSize();

        public Entry Add(Entry entry)
        {
            throw new FileTreatmentException();
        }

        public IEnumerator Enumerator()
        {
            throw new FileTreatmentException();
        }

        public override string ToString()
        {
            return GetName() + " (" + GetSize() + ")";
        }

        public abstract void Accept(Visitor v);
    }
}
