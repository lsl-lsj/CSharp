using System;
using static System.Console;

/*
 * 按位平移
 */

namespace Demo02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 305;
            int y = 1060;
            WriteLine($"{Convert.ToString(x, 2)} 向左移动3位后 {Convert.ToString(x << 3, 2)}");
            WriteLine($"{Convert.ToString(y, 2)} 向右移动4位后 {Convert.ToString(y >> 4, 2)}");
        }
    }
}