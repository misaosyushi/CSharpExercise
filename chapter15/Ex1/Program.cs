using System;
using System.Linq;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1_2();
            Console.WriteLine("-----");
            Ex1_3();
            Console.WriteLine("-----");
            Ex1_4();
            Console.WriteLine("-----");
            Ex1_5();
            Console.WriteLine("-----");
            Ex1_6();
            Console.WriteLine("-----");
            Ex1_7();
            Console.WriteLine("-----");
            Ex1_8();
        }

        static void Ex1_2()
        {
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.FirstOrDefault(b => b.Price == max);
            Console.WriteLine("{0} {1}", book?.Title, book?.Price);
        }

        static void Ex1_3()
        {
            var books = Library.Books.GroupBy(b => b.PublishedYear)
                .Select(g => new {PublishYear = g.Key, Count = g.Count()})
                .OrderBy(g => g.PublishYear);
            foreach (var book in books)
            {
                Console.WriteLine("{0} {1}", book.PublishYear, book.Count);
            }
        }

        static void Ex1_4()
        {
            var books = Library.Books
                .Join(Library.Categories,
                    book => book.CategoryId,
                    category => category.Id,
                    (book, category) => new
                    {
                        book.PublishedYear,
                        book.Title,
                        book.Price,
                        CategoryName = category.Name
                    })
                .OrderByDescending(b => b.PublishedYear)
                .ThenByDescending(b => b.Price);
            foreach (var book in books)
            {
                Console.WriteLine("{0} {1} {2} ({3})", book.PublishedYear, book.Price, book.Title, book.CategoryName);
            }
        }

        static void Ex1_5()
        {
            var categories = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,
                    book => book.CategoryId,
                    category => category.Id,
                    (book, category) => new
                    {
                        category.Name
                    })
                .Distinct();
            foreach (var c in categories)
            {
                Console.WriteLine(c);
            }
        }

        static void Ex1_6()
        {
            var result = Library.Books
                .Join(Library.Categories,
                    book => book.CategoryId,
                    category => category.Id,
                    (book, category) => new
                    {
                        book.Title,
                        CategoryName = category.Name
                    })
                .GroupBy(x => x.CategoryName)
                .OrderBy(y => y.Key);
            foreach (var r in result)
            {
                Console.WriteLine("#{0}", r.Key);
                foreach (var book in r)
                {
                    Console.WriteLine("  {0}", book.Title);
                }
            }
        }

        static void Ex1_7()
        {
            var result = Library.Books
                .Join(Library.Categories,
                    book => book.CategoryId,
                    category => category.Id,
                    (book, category) => new
                    {
                        book.Title,
                        book.PublishedYear,
                        CategoryName = category.Name
                    })
                .Where(b => b.CategoryName == "Development")
                .GroupBy(x => x.PublishedYear)
                .OrderBy(y => y.Key);
            foreach (var r in result)
            {
                Console.WriteLine("#{0}", r.Key);
                foreach (var book in r)
                {
                    Console.WriteLine("  {0}", book.Title);
                }
            }
        }

        static void Ex1_8()
        {
            var result = Library.Categories
                .GroupJoin(Library.Books,
                    category => category.Id,
                    book => book.CategoryId,
                    (category, books) => new
                    {
                        CategoryName = category.Name,
                        Count = books.Count()
                    })
                .Where(x => x.Count >= 4);
            foreach (var r in result)
            {
                Console.WriteLine(r.CategoryName);
            }
        }
    }
}