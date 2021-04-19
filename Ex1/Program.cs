using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dorayaki = new Product(98, "どらやき", 210);
            Console.WriteLine(dorayaki.GetTax());
        }
    }
}