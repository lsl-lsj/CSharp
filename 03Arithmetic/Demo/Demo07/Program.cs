using System;
using System.Numerics;

/*
 * BigInteger 超大整数类型
 */

namespace Demo07
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = 300;

            BigInteger bi = 1;

            while (n > 1)
            {
                bi *= n;
                n--;
            }

            Console.WriteLine("{0}的阶乘：\n{1}", n, bi);
        }
    }
}