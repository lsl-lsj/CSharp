using System;

/*
 * 递归计算一个整数的阶乘
 */

namespace Demo01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("请输入一个整数:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Compute(n));
        }

        private static int Compute(int n)
        {
            if (n > 1)
            {
                return n * Compute(n - 1);
            }
            return 1;
        }
    }
}