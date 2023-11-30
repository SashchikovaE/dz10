using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("дз 12.2");
            Book book1 = new Book("лолита", "набоков", "издательство1");
            Book book2 = new Book("яма", "куприн", "издательство2");
            Book book3 = new Book("морфий", "булгаков", "издательство3");

            Book[] booksArray = { book3, book1, book2 };
            BookCollection bookCollection = new BookCollection(booksArray);

            BookComparer sortByTitle = (x, y) => x.title.CompareTo(y.title);
            BookComparer sortByAuthor = (x, y) => x.author.CompareTo(y.author);
            BookComparer sortByPublisher = (x, y) => x.publisher.CompareTo(y.publisher);

            Console.WriteLine("отсортировано по названию:");
            bookCollection.SortBooks(sortByTitle);
            bookCollection.DisplayBooks();

            Console.WriteLine("отсортировано по автору:");
            bookCollection.SortBooks(sortByAuthor);
            bookCollection.DisplayBooks();

            Console.WriteLine("отсортировано по изданию:");
            bookCollection.SortBooks(sortByPublisher);
            bookCollection.DisplayBooks();

            Console.WriteLine("упражнение 12.2");
            RationalNumber a = new RationalNumber(2, 5);
            RationalNumber b = new RationalNumber(1, 4);

            bool Equal = a == b;
            bool NotEqual = a != b;
            bool LessThan = a < b;
            bool GreaterThan = a > b;
            bool LessThanOrEqual = a <= b;
            bool GreaterThanOrEqual = a >= b;
            Console.WriteLine($"a == b {Equal}");
            Console.WriteLine($"a != b {NotEqual}");
            Console.WriteLine($"a < b {LessThan}");
            Console.WriteLine($"a > b {GreaterThan}");
            Console.WriteLine($"a <= b {LessThanOrEqual}");
            Console.WriteLine($"a >= b {GreaterThanOrEqual}");

            RationalNumber sum = a + b;
            RationalNumber difference = a - b;
            RationalNumber product = a * b;
            RationalNumber quotient = a / b;
            RationalNumber remainder = a % b;
            Console.WriteLine($"a + b = {sum}");
            Console.WriteLine($"a - b =  {difference}");
            Console.WriteLine($"a * b = {product}");
            Console.WriteLine($"a / b = {quotient}");
            Console.WriteLine($"a % b = {remainder}");

            RationalNumber c = new RationalNumber(8, 5);
            RationalNumber incremented = c++;
            RationalNumber decremented = c--;
            Console.WriteLine(incremented);
            Console.WriteLine(decremented);

            float floatValue = (float)a;
            int intValue = (int)b;
            Console.WriteLine(floatValue);
            Console.WriteLine(intValue);

            Console.WriteLine("дз 12.1");
            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, -1);

            Console.WriteLine($"c1 = {c1}");
            Console.WriteLine($"c2 = {c2}");

            ComplexNumber sum1 = c1 + c2;
            ComplexNumber difference1 = c1 - c2;
            ComplexNumber product1 = c1 * c2;

            Console.WriteLine($"c1 + c2 = {sum1}");
            Console.WriteLine($"c1 - c2 = {difference1}");
            Console.WriteLine($"c1 * c2 = {product1}");

            Console.WriteLine($"c1 == c2: {c1 == c2}");
            Console.WriteLine($"c1 != c2: {c1 != c2}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}