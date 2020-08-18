using System;
using System.Reflection;

/*
 * typeof运算符
 */

namespace Demo03
{
    public abstract class Person
    {
        public abstract int Age { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Type t = typeof(Person);
            Console.WriteLine($"完整包名 ：{t.FullName}");
            Console.WriteLine($"是否为抽象类{0}", t.IsAbstract ? "是" : "否");
            Console.WriteLine($"是否为公共类{0}", t.IsPublic ? "是" : "否");

            PropertyInfo[] props = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine("\n\n----- 属性列表 -----");
            foreach (var p in props)
            {
                Console.WriteLine($"{p.Name,-15}{p.PropertyType.Name,-15}");
            }
        }
    }
}