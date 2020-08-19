using System;

/*
 * 今天星期几
 */

namespace Demo01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            Console.WriteLine(today.ToString("yyyy-MM-dd hh:mm:ss "));

            var weekday = today.DayOfWeek;
            Console.WriteLine(weekday.ToString());
        }
    }
}