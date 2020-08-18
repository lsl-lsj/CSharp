using System;

/*
 * 幂运算
 */

namespace Demo06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[] srcnums = { 5, 3, 7, 4, 6 };
            foreach (double d in srcnums)
            {
                Console.WriteLine("{0}的立方为{1}", d, Math.Pow(d, 3));
            }
        }
    }
}