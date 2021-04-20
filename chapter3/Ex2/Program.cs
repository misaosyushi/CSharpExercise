using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong"
            };
            Ex2_1(names);
            Console.WriteLine("-----");
            Ex2_2(names);
            Console.WriteLine("-----");
            Ex2_3(names);
            Console.WriteLine("-----");
            Ex2_4(names);
        }

        static void Ex2_1(List<string> names)
        {
            Console.WriteLine("都市名を入力してください。");
            var lines = Console.ReadLine();
            var index = names.FindIndex(s => s == lines);
            Console.WriteLine(index);
        }

        static void Ex2_2(List<string> names)
        {
            var count = names.Count(s => s.Contains("o"));
            Console.WriteLine(count);
        }

        static void Ex2_3(List<string> names)
        {
            var results = names.Where(s => s.Contains("o")).ToList();
            foreach (var res in results)
            {
                Console.WriteLine(res);
            }
        }

        static void Ex2_4(List<string> names)
        {
            var results = names.Where(s => s.StartsWith("B"))
                .Select(s => s.Length).ToList();
            foreach (var res in results)
            {
                Console.WriteLine(res);
            }
        }
    }
}