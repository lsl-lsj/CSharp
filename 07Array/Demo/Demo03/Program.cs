using System;
using System.Linq;

/*
* 动态调整数组的大小
*/

namespace Demo03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[] arr = { 2.3, 2.21, 24 };
            Console.WriteLine("{0} , {1}", $"原数组的大小为{arr.Length}", $"元素为{string.Join(", ", from i in arr select i)}");

            Array.Resize(ref arr, 6);
            Console.WriteLine("{0} , {1}", $"原数组的大小为{arr.Length}", $"元素为{string.Join(", ", from i in arr select i)}");
        }
    }
}