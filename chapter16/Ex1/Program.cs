using System;
using System.IO;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1_1();
        }

        static async void Ex1_1()
        {
            using (StreamReader reader = File.OpenText("test.txt"))
            {
                Console.WriteLine("Open Text.");
                var result = await reader.ReadLineAsync();
                Console.WriteLine("First line contains: " + result);
            }
        }
    }
}