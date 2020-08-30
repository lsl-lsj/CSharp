using System;

/*
 * 使用Array类创建数组实例 以及 GetValue和SetValue方法
 */

namespace Demo02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[,,,] arr = (string[,,,])Array.CreateInstance(typeof(string), 3, 4, 5, 6);

            Array darr = Array.CreateInstance(typeof(double), 7);

            darr.SetValue(3.2, 3);
            Console.WriteLine(darr.GetValue(3));
        }
    }
}