using System;
using System.Linq;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] {5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35};
            Ex1_1(numbers);
            Console.WriteLine("-----");
            Ex1_2(numbers);
            Console.WriteLine("-----");
            Ex1_3(numbers);
            Console.WriteLine("-----");
            Ex1_4(numbers);
            Console.WriteLine("-----");
            Ex1_5(numbers);
        }

        static void Ex1_1(int[] numbers)
        {
            var max = numbers.Max();
            Console.WriteLine(max);
        }

        static void Ex1_2(int[] numbers)
        {
            var skip = numbers.Length - 2;
            foreach (var number in numbers.Skip(skip))
            {
                Console.WriteLine(number);
            }
        }
        
        static void Ex1_3(int[] numbers)
        {
            foreach (var number in numbers.Select(n => n.ToString()))
            {
                Console.WriteLine(number);
            }
        }
        
        static void Ex1_4(int[] numbers)
        {
            foreach (var n in numbers.OrderBy(n => n).Take(3))
            {
                Console.WriteLine(n);
            }
        }
        
        static void Ex1_5(int[] numbers)
        {
            var res = numbers.Distinct().Count(n => n > 10);
            Console.WriteLine(res);
        }
    }
}