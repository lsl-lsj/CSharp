using System;
using System.Collections.Generic;
using System.Dynamic;

/*
* ExpandoObject类显示实现了IDictionary接口
*/

namespace Demo04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            dynamic d = new ExpandoObject();
            d.AppName = "Sample";
            d.Ver = "1.0.3";
            d.Desc = "test application";
            d.Release = 5;

            IDictionary<string, Object> dic = d;

            foreach (var item in dic)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}