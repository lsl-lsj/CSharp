using System;
using System.Text;

/*
 * 获取命令行参数
 * 处理多个入口点 -- 属性-> 应用程序->启动对象
 */

namespace Demo03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("接收到的命令行参数：");
            foreach (var item in args)
            {
                sb.AppendFormat("{0}", item);
            }

            Console.WriteLine(sb);
        }
    }

    //internal class Test
    //{
    //    private static void Main(string[] args)
    //    {
    //    }
    //}
}