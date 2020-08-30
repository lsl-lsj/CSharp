using System;
using System.Collections.Generic;
using System.Dynamic;

/*
 * 在自定义动态类型中直接定义成员
 *
 * 每次调用成员 都会调用重写的方法
 */

namespace Demo05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            dynamic d = new MyDynamic();

            d.WorkName = "冲压工序";
            d.WorkDescription = "此工序";
            d.IsStarted = false;
            d.WorkType = 15;
            d.StartTime = new DateTime(2018, 8, 3);

            Console.WriteLine($"Work Name : {d.WorkName}");
            Console.WriteLine($"Start Time : {d.StartTime}");
            Console.WriteLine($"Work Type : {d.WorkType}");
        }
    }

    internal class MyDynamic : DynamicObject
    {
        private IDictionary<string, object> data = new Dictionary<string, object>();

        // 明确定义的属性，动态类型会直接访问该属性
        public string WorkDescription { get; set; }

        public string WorkName { get; set; }
        public bool IsStarted { get; set; }

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            Console.WriteLine($"\n类中未定义的成员：{binder.Name}\n");
            return data.TryAdd(binder.Name.ToLower(), value);
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            Console.WriteLine($"\n类中未定义的成员：{binder.Name}\n");
            return data.TryGetValue(binder.Name.ToLower(), out result);
        }
    }
}