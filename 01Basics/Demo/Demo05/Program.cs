using System;

/*
 * 键盘输入
 * 判断是否为数字
 */

namespace Demo05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("请输入一个数字：");
            string input = Console.ReadLine();

            if (uint.TryParse(input, out uint number) && number > 0)
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("输入的内容无效");
            }
        }
    }
}