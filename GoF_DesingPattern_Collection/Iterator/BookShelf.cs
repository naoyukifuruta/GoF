using System;
namespace Iterator
{
    public class BookShelf : IAggregate
    {
        private Book[] _books;

        private int _last = 0;

        public BookShelf(int maxsize)
        {
            this._books = new Book[maxsize];
        }

        public Book GetBookAt(int index)
        {
            return _books[index];
        }

        public void AppendBook(Book book)
        {
            this._books[_last] = book;
            _last++;
        }

        public int GetLength()
        {
            return _last;
        }

        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
