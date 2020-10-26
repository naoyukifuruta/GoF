
namespace Iterator
{
    public class BookShelfIterator : IIterator
    {
        public BookShelf BookShelf { get; set; }

        public int Index { get; set; }

        public BookShelfIterator(BookShelf bookShelf)
        {
            BookShelf = bookShelf;
            Index = 0;
        }

        public bool HasNext()
        {
            if (Index < BookShelf.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public object Next()
        {
            Book book = BookShelf.GetBookAt(Index);
            Index++;
            return book;
        }
    }
}
