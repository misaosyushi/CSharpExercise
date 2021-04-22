using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearMonths = new YearMonth[]
            {
                new YearMonth(2020, 1),
                new YearMonth(2021, 1),
                new YearMonth(2022, 1),
                new YearMonth(2023, 1),
                new YearMonth(2024, 1),
            };
            Console.WriteLine(yearMonths);
            Console.WriteLine("-----");
            Ex2_1(yearMonths);
            Console.WriteLine("-----");
            Ex2_3(yearMonths);
            Console.WriteLine("-----");
            Ex2_4(yearMonths);
        }

        static void Ex2_1(YearMonth[] yearMonths)
        {
            foreach (var ym in yearMonths)
            {
                Console.WriteLine($"{ym.Year}年{ym.Month}月");
            }
        }

        static YearMonth Ex2_2(YearMonth[] yearMonths)
        {
            foreach (var ym in yearMonths)
            {
                if (ym.Is21Century)
                    return ym;
            }

            return null;
        }

        static void Ex2_3(YearMonth[] yearMonths)
        {
            var yearMonth = Ex2_2(yearMonths);
            var s = yearMonths == null ? "21世紀のデータはありません。" : yearMonth.ToString();
            Console.WriteLine(s);
        }

        static void Ex2_4(YearMonth[] yearMonths)
        {
            var res = yearMonths.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var r in res)
            {
                Console.WriteLine(r.ToString());
            }
        }
    }

    public class YearMonth
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