using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Ex1_1(text);
            Console.WriteLine("-----");
            Ex1_2(text);
        }

        static void Ex1_1(string text)
        {
            var dict = new Dictionary<Char, int>();
            foreach (var c in text)
            {
                var uc = char.ToUpper(c);
                if ('A' <= uc && uc <= 'Z')
                {
                    if (dict.ContainsKey(uc))
                        dict[uc]++;
                    else
                        dict[uc] = 1;
                }
            }
            foreach (var keyValuePair in dict.OrderBy(s => s.Key))
            {
                Console.WriteLine("{0} : {1}", keyValuePair.Key, keyValuePair.Value);
            }
        }
        
        static void Ex1_2(string text)
        {
            var dict = new SortedDictionary<Char, int>();
            foreach (var c in text)
            {
                var uc = char.ToUpper(c);
                if ('A' <= uc && uc <= 'Z')
                {
                    if (dict.ContainsKey(uc))
                        dict[uc]++;
                    else
                        dict[uc] = 1;
                }
            }
            foreach (var keyValuePair in dict)
            {
                Console.WriteLine("{0} : {1}", keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}