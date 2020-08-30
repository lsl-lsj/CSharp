using System;

/*
 * 将泛型参数限制为枚举类型
 */

namespace Demo02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            (string Name, int Val) tes = CallTest<Oper>(Oper.Close);

            Console.WriteLine($"常量名称为：{tes.Name}, 常量值：{tes.Val}");
        }

        private static (string, int) CallTest<T>(T p)
            where T : Enum
        {
            // 获取常亮名称
            string name = Enum.GetName(p.GetType(), p);

            // 获取常值
            int value = Convert.ToInt32(p);
            return (name, value);
        }
    }

    internal enum Oper
    {
        Open = 5,
        Close = 12,
        Reset = 6
    }
}