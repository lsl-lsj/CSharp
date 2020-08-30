using System;

/*
 * 四种初始化数组的实例
 */

namespace Demo01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] a = new int[3];
            int[] b = new int[3] { 1, 23, 3 };
            int[] c = new int[] { 1, 2, 3, 4, 5 };
            int[] d = { 1, 2, 3, 4, 5, 6 };
        }
    }
}