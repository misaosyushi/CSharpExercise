using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>
            {
                new Book {Title = "C#プログラミングの新常識", Price = 3800, Pages = 378},
                new Book {Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312},
                new Book {Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385},
                new Book {Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464},
                new Book {Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604},
                new Book {Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453},
                new Book {Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348},
            };

            Ex2_1(books);
            Console.WriteLine("-----");
            Ex2_2(books);
            Console.WriteLine("-----");
            Ex2_3(books);
            Console.WriteLine("-----");
            Ex2_4(books);
            Console.WriteLine("-----");
            Ex2_5(books);
            Console.WriteLine("-----");
            Ex2_6(books);
            Console.WriteLine("-----");
            Ex2_7(books);
        }

        static void Ex2_1(List<Book> books)
        {
            var book = books.FirstOrDefault(b => b.Title == "ワンダフル・C#ライフ");
            Console.WriteLine($"{book?.Price}円、{book?.Pages}ページ");
        }

        static void Ex2_2(List<Book> books)
        {
            var count = books.Count(b => b.Title.Contains("C#"));
            Console.WriteLine(count);
        }

        static void Ex2_3(List<Book> books)
        {
            var average = books.Where(b => b.Title.Contains("C#"))
                .Average(b => b.Pages);
            Console.WriteLine(average);
        }
        
        static void Ex2_4(List<Book> books)
        {
            var book = books.FirstOrDefault(b => b.Price >= 4000);
            Console.WriteLine(book?.Title);
        }
        
        static void Ex2_5(List<Book> books)
        {
            var pages = books.Where(b => b.Price < 4000)
                .Max(b => b.Pages);
            Console.WriteLine(pages);
        }
        
        static void Ex2_6(List<Book> books)
        {
            var res = books.Where(b => b.Pages >= 400)
                .OrderByDescending(b => b.Price);
            foreach (var book in res)
            {
                Console.WriteLine("{0} {1}", book.Title, book.Price);
            }
        }
        
        static void Ex2_7(List<Book> books)
        {
            var res = books.Where(b => b.Title.Contains("C#") && b.Pages <= 500);
            foreach (var book in res)
            {
                Console.WriteLine(book.Title);
            }
        }
    }

    class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
}