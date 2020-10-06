using System;
namespace Iterator
{
    public class BookShelfIterator : IIterator
    {
        private BookShelf _bookShelf;

        private int _index;

        public BookShelfIterator(BookShelf bookShelf)
        {
            this._bookShelf = bookShelf;
            this._index = 0;
        }

        public bool HasNext()
        {
            if (_index < _bookShelf.GetLength())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Object Next()
        {
            var book = _bookShelf.GetBookAt(_index);
            _index++;
            return book;
        }
    }
}
