using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookShelf = new BookShelf();
            bookShelf.AppendBook(new Book("Around the World in 80 Days"));
            bookShelf.AppendBook(new Book("Bible"));
            bookShelf.AppendBook(new Book("Cinderella"));
            bookShelf.AppendBook(new Book("Daddy-Long-Legs"));

            var iterator = bookShelf.Iterator();
            while (iterator.HasNext())
            {
                var book = (Book)iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }

    /** 便宜上1ファイルに全クラスを実装 */

    public interface IAggregate
    {
        IIterator Iterator();
    }

    public interface IIterator
    {
        bool HasNext();
        object Next();
    }

    public class Book
    {
        public string Name { get; set; }

        public Book(string name)
        {
            Name = name;
        }
    }

    public class BookShelf : IAggregate
    {
        private List<Book> _books = new List<Book>();

        public Book GetBookAt(int index)
        {
            return _books[index];
        }

        public void AppendBook(Book book)
        {
            _books.Add(book);
        }

        public int GetLength()
        {
            return _books.Count;
        }

        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }

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
