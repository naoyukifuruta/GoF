
namespace Composite
{
    public abstract class Entry
    {

        public abstract string GetName();
        public abstract int GetSize();

        public Entry Add(Entry entry)
        {
            throw new FileTreatmentException();
        }

        public void PrintList()
        {
            PrintList("");
        }

        protected abstract void PrintList(string prefix);

        public new string ToString()
        {
            return GetName() + "(" + GetSize() + ")";
        }
    }
}
