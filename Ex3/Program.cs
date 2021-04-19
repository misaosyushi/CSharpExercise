using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student
            {
                Name = "hoge",
                Birthday = new DateTime(2021, 4, 20),
                Grade = 1,
                ClassNumber = 1
            };
            Console.WriteLine("{0} - {1}年{2}組 {3:yyyy/M/d}生まれ", student.Name, student.Grade, student.ClassNumber,
                student.Birthday);

            Person person = student;
            if (person is Student)
                Console.WriteLine("person is Student");

            object obj = student;
            if (obj is Student)
                Console.WriteLine("obj is Student");
        }
    }
}