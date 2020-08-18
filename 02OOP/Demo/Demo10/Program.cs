using System;
using System.Reflection;

/*
 * 在运行阶段检索特性实例
 */

namespace Demo10
{
    // 声明一个特性类
    [AttributeUsage(AttributeTargets.Property)]
    public class MyAttribute : Attribute
    {
        public char StartChar { get; set; }
        public int MaxLen { get; set; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Test v = new Test { RawName = "ka13f" };
            if (CheckTest(v, nameof(v.RawName)))
            {
                Console.WriteLine("验证通过");
            }
            else
            {
                Console.WriteLine("验证未通过");
            }
        }

        public static bool CheckTest(Test t, string property)
        {
            // 获取类型信息
            Type type = t.GetType();

            // 查找属性成员
            PropertyInfo prop = type.GetProperty(property, BindingFlags.Public | BindingFlags.Instance);
            if (prop == null)
                return false;

            // 获取特性
            MyAttribute att = prop.GetCustomAttribute<MyAttribute>();

            // 获取实例的属性值
            string value = prop.GetValue(t) as string;
            if (string.IsNullOrEmpty(value))
                return false;

            // 进项验证
            if (value.StartsWith(att.StartChar) == false)
                return false;
            if (value.Length > att.MaxLen)
                return false;
            return true;
        }
    }

    // 测试类
    public class Test
    {
        [My(StartChar = 'k', MaxLen = 7)]
        public string RawName { get; set; }
    }
}