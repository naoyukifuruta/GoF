using System.Collections.Generic;

namespace Iterator
{
    public class BookShelf : IAggregate
    {
        private List<Book> _books;

        public BookShelf()
        {
            this._books = new List<Book>();
        }

        public Book GetBookAt(int index)
        {
            return _books[index];
        }

        public void AppendBook(Book book)
        {
            this._books.Add(book);
        }

        public int GetLength()
        {
            return this._books.Count;
        }

        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}
