using System;
using System.Dynamic;

/*
 * ExpandoObject类创建动态实例
 */

namespace Demo03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            dynamic dx = new ExpandoObject();
            dx.Message = "Hello";
            dx.Time = DateTime.Now;
            Console.WriteLine("Message: {0}\nTime: {1}", dx.Message, dx.Time);
        }
    }
}