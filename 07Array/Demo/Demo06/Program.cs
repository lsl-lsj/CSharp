using System;
using System.Diagnostics;

/*
 * 使用ReadOnlySpan<T>提升处理字符串性能
 */

namespace Demo06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string str = "我家里养了20只猫";
            One(str);
            Two(str);
        }

        private static void One(string str)
        {
            Stopwatch sw1 = Stopwatch.StartNew();

            int v = default(int);

            for (int i = 0; i < 10000000; i++)
            {
                v = int.Parse(str.Substring(5, 2));
            }
            sw1.Stop();
            Console.WriteLine("Substring取到{0}  所用时间为{1}ms", v, sw1.ElapsedMilliseconds);
        }

        private static void Two(string str)
        {
            Stopwatch sw2 = Stopwatch.StartNew();

            int v = default(int);

            ReadOnlySpan<char> ros = str.ToCharArray();
            for (int i = 0; i < 10000000; i++)
            {
                v = 0;
                var sub = ros.Slice(5, 2);
                foreach (var item in sub)
                {
                    char ch = item;
                    v = (ch - '0') + v * 10;
                }
            }
            sw2.Stop();
            Console.WriteLine("Span<T>取到{0}  所用时间为{1}ms", v, sw2.ElapsedMilliseconds);
        }
    }
}