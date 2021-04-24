using System;
using System.Linq;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var abbreviations = new Abbreviations();
            abbreviations.Add("test1", "テスト1");
            abbreviations.Add("test2", "テスト2");
            Ex2_3(abbreviations);
            Console.WriteLine("-----");
            Ex2_4(abbreviations);
        }

        static void Ex2_3(Abbreviations abbreviations)
        {
            Console.WriteLine(abbreviations.Count);
            abbreviations.Remove("test1");
            foreach (var keyValuePair in abbreviations)
            {
                Console.WriteLine("{0}={1}", keyValuePair.Key, keyValuePair.Value);
            }
        }
        
        static void Ex2_4(Abbreviations abbreviations)
        {
            var res = abbreviations.Where(a => a.Key.Length == 3);
            foreach (var keyValuePair in res)
            {
                Console.WriteLine("{0}={1}", keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}