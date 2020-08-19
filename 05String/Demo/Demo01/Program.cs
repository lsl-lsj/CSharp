using System;

/*
 * IsDigit和IsNumber判断是否为数字
 */

namespace Demo01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char[] charr = { '3', 'f', '⑳', '#', '⑹', '⒏', 's', 'Ⅶ', 'ⅸ', '❻', '㈦' };

            foreach (var c in charr)
            {
                Console.WriteLine("{0,-10}{1}数字", c, char.IsNumber(c) ? "是" : "不是");
            }
        }
    }
}