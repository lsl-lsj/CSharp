using System;
using System.Reflection;

/*
 * 重命名元组的字段 实际字段名称依然是item *
 */

namespace Demo07
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            (int Id, string Title, string Body) v = (1, "demo", "some one");

            v.Title = "The Best";

            var w = (Count: 99, '*');

            Type t = w.GetType();

            FieldInfo[] fds = t.GetFields(BindingFlags.Public | BindingFlags.Instance);

            Console.WriteLine("元组的运行时类型 {0}", t.Name);

            string infos = string.Empty;

            foreach (var item in fds)
            {
                infos += $"{item.Name}:{item.FieldType.Name}\n";
            }
            Console.WriteLine("字段名称和类型:\n{0}", infos);
        }
    }
}