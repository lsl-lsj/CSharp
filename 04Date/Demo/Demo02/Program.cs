using System;
using System.Globalization;

/*
* 获取农历日期
*/

namespace Demo02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ChineseLunisolarCalendar clc = new ChineseLunisolarCalendar();

            // 指定日期
            DateTime d1 = new DateTime(2017, 12, 18);
            DateTime d2 = new DateTime(2018, 3, 20);
            DateTime d3 = new DateTime(2017, 5, 15);

            Console.WriteLine($"{d1:d},农历：{clc.GetMonth(d1)} 月 {clc.GetDayOfMonth(d1)} 日");
            Console.WriteLine($"{d2:d},农历：{clc.GetMonth(d2)} 月 {clc.GetDayOfMonth(d2)} 日");
            Console.WriteLine($"{d3:d},农历：{clc.GetMonth(d3)} 月 {clc.GetDayOfMonth(d3)} 日");
        }
    }
}