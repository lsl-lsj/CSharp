using System;

/*
 * 将整数转换为十六进制字符串
 */

namespace Demo04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 91545588;
            Console.WriteLine("{0} -> 0x{1}", x, x.ToString("X2"));
        }
    }
}