using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() {12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48};
            Ex1_1(numbers);
            Console.WriteLine("-----");
            Ex2_2(numbers);
            Console.WriteLine("-----");
            Ex2_3(numbers);
            Console.WriteLine("-----");
            Ex2_4(numbers);
        }

        static void Ex1_1(List<int> numbers)
        {
            var exists = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            if (exists)
                Console.WriteLine("exist");
            else
                Console.WriteLine("not exists");
        }

        static void Ex2_2(List<int> numbers)
        {
            numbers.ForEach(n => Console.WriteLine(n / 2.0));
        }

        static void Ex2_3(List<int> numbers)
        {
            foreach (var i in numbers.Where(n => n >= 50))
            {
                Console.WriteLine(i);
            }
        }

        static void Ex2_4(List<int> numbers)
        {
            foreach (var i in numbers.Select(n => n * 2).ToList())
            {
                Console.WriteLine(i);
            }
        }
    }
}