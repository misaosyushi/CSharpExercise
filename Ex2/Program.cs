using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj1 = new MyClass {X = 10, Y = 20};
            var obj2 = new MyStruct {X = 100, Y = 200};
            PrintObjects(obj1, obj2);
        }

        static void PrintObjects(MyClass obj1, MyStruct obj2)
        {
            obj1.X *= 2;
            obj1.Y *= 2;
            obj2.X *= 2;
            obj2.Y *= 2;
            Console.WriteLine("MyClass: {0}, {1}", obj1.X, obj1.Y);
            Console.WriteLine("MyClass: {0}, {1}", obj2.X, obj2.Y);
        }
    }
}