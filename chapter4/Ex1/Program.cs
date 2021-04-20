using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class YearMonth
    {
        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }

        public int Year { get; private set; }
        public int Month { get; private set; }

        public bool Is21Century
        {
            get { return 2001 <= Year && Year <= 2100; }
        }

        public YearMonth AddOneMonth()
        {
            if (this.Month == 12)
            {
                return new YearMonth(this.Year + 1, 1);
            }

            return new YearMonth(this.Year, this.Month + 1);
        }

        public override string ToString()
        {
            return $"{Year}年{Month}月";
        }
    }
}