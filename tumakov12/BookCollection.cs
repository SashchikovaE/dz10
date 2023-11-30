using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov12
{
    delegate int BookComparer(Book x, Book y);
    internal class BookCollection
    {
        public Book[] books;
        public BookCollection(Book[] books)
        {
            this.books = books;
        }
        public void SortBooks(BookComparer comparer)
        {
            Array.Sort(books, new Comparison<Book>((x, y) => comparer(x, y)));
        }
        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"название: {book.title}, автор: {book.author}, издательство: {book.publisher}");
            }
        }
    }
}
