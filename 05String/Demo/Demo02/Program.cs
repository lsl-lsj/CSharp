using System;
using System.Globalization;

/*
 * 格式控制符
 */

namespace Demo02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("输出百分比:");
            P();
            Console.WriteLine("\n输出当前语言的货币格式:");
            C();
            Console.WriteLine("\n输出多个币种格式:");
            Get();
            Console.WriteLine("\n数字的两种表示格式:");
            GN();
            Console.WriteLine("\n长日期和短日期格式:");
            LS();
        }

        // 输出百分比
        private static void P()
        {
            double d = 2.22231;
            Console.WriteLine($"{"p",-10}{d,-10:p6}");
        }

        // 输出当前语言的货币格式
        private static void C()
        {
            Console.WriteLine("{0,-10}{1,-10:c3}", 'c', 20.532123);
        }

        // 输出多个币种格式
        private static void C(string area, IFormatProvider provider)
        {
            decimal dl = 2.231m;
            Console.WriteLine("{0,-4}{1}", area, dl.ToString("c", provider));
        }

        private static void Get()
        {
            CultureInfo cn = CultureInfo.GetCultureInfoByIetfLanguageTag("zh-CN");
            CultureInfo tw = CultureInfo.GetCultureInfoByIetfLanguageTag("zh-TW");
            CultureInfo us = CultureInfo.GetCultureInfoByIetfLanguageTag("en-US");
            CultureInfo mo = CultureInfo.GetCultureInfoByIetfLanguageTag("zh-MO");
            CultureInfo hk = CultureInfo.GetCultureInfoByIetfLanguageTag("zh-HK");
            CultureInfo jp = CultureInfo.GetCultureInfoByIetfLanguageTag("zh-JP");
            C("人民币", cn);
            C("台币", tw);
            C("美元", us);
            C("澳元", mo);
            C("港币", hk);
            C("日元", jp);
        }

        // 数字的两种表示格式
        private static void GN()
        {
            decimal val = 8582113.76352M;
            Console.WriteLine($"p   {val,-20:G}");
            Console.WriteLine($"p   {val,-20:N5}");
        }

        // 长日期和短日期格式
        private static void LS()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine($"{dt:D}");
            Console.WriteLine($"{dt:d}");
        }
    }
}