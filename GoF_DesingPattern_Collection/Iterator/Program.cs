using System;

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
}
